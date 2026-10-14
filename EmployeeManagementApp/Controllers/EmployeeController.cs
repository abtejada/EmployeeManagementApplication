using EmployeeManagementApp.Models;
using EmployeeManagementApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly PMMContext _context;

        // Inject PMMContext via Dependency Injection
        public EmployeeController(PMMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string? searchTerm)
        {
            bool hasSearched = !string.IsNullOrWhiteSpace(searchTerm);
            ViewData["HasSearched"] = hasSearched;
            ViewData["CurrentFilter"] = searchTerm;

            // Guard clause: If user hasn't searched yet, return an empty list immediately
            if (!hasSearched)
            {
                return View(new List<EmployeeDirectoryViewModel>());
            }

            var personnelQuery = _context.PmsPersonnelInformations.AsQueryable();
            var occupationQuery = _context.TimekeepingOccupationDetails.AsQueryable();
            var divisionQuery = _context.TimekeepingDivisions.AsQueryable();

            var term = searchTerm.Trim();
            personnelQuery = personnelQuery.Where(p =>
                (p.GivenName + " " + p.Surname).Contains(term) ||
                (p.EmployeeId != null && p.EmployeeId.Contains(term)));

            var personnelList = await personnelQuery.ToListAsync();
            var occupationList = await occupationQuery.ToListAsync();
            var divisionList = await divisionQuery.ToListAsync(); // Or standard division query

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            var employeeDirectory = personnelList.Select(p =>
            {
                var occ = occupationList.FirstOrDefault(o => o.HrisId.ToString().Trim() == p.HrisId.ToString().Trim());

                var div = (occ != null && occ.Division.HasValue)
                    ? divisionList.FirstOrDefault(d => d.Id == occ.Division.Value)
                    : null;

                string hrisIdStr = p.HrisId.ToString().Trim() ?? "";
                string deptName = div != null ? (div.Sname ?? "Unassigned") : "Unassigned";

                bool hasSeparationValue = occ != null && occ.SeparationDate.HasValue;
                bool isCurrentlySeparated = false;
                string sepDateFormatted = "";

                if (hasSeparationValue)
                {
                    DateOnly sepDateOnly = DateOnly.FromDateTime(occ.SeparationDate.Value);
                    sepDateFormatted = sepDateOnly.ToString("yyyy-MM-dd");
                    isCurrentlySeparated = sepDateOnly <= today;
                }

                bool isActive = !isCurrentlySeparated;

                return new EmployeeDirectoryViewModel
                {
                    EmployeeId = p.EmployeeId ?? "N/A",
                    EmployeeCode = hrisIdStr,
                    FullName = ((p.GivenName ?? "") + " " + (p.Surname ?? "")).Trim(),
                    Department = deptName,
                    DivisionShortName = deptName,
                    Position = occ != null && occ.Position != null ? occ.Position.ToString() : "Unassigned",
                    IsActive = isActive,
                    SeparationDateFormatted = sepDateFormatted,
                    SeparationReason = occ?.SeparationReason ?? "",
                    HasExistingSeparation = hasSeparationValue
                };
            }).ToList();

            return View(employeeDirectory);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSeparation(string employeeCode, DateOnly? separationDate, string? separationReason)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (int.TryParse(employeeCode, out int hrisId))
                {
                    var occupationDetail = await _context.TimekeepingOccupationDetails
                        .FirstOrDefaultAsync(o => o.HrisId == hrisId);

                    DateTime? convertedDate = separationDate.HasValue ? separationDate.Value.ToDateTime(TimeOnly.MinValue) : null;

                    if (occupationDetail != null)
                    {
                        occupationDetail.SeparationDate = convertedDate;
                        occupationDetail.SeparationReason = separationDate.HasValue ? separationReason : null;
                        _context.Entry(occupationDetail).State = EntityState.Modified;
                    }
                    else if (separationDate.HasValue)
                    {
                        var newOccupation = new TimekeepingOccupationDetail
                        {
                            HrisId = hrisId,
                            SeparationDate = convertedDate.Value,
                            SeparationReason = separationReason
                        };
                        _context.TimekeepingOccupationDetails.Add(newOccupation);
                    }

                    // Capture the actual user input remarks, or fall back depending on whether date is set or cleared
                    string finalReason = !string.IsNullOrWhiteSpace(separationReason)
                        ? separationReason
                        : (separationDate.HasValue ? "Separation date updated" : "Separation date removed / Restored to active");

                    // Record history into your EmployeeSeparationHistories table using your exact model properties
                    var newHistory = new EmployeeSeparationHistory
                    {
                        HrisId = hrisId,
                        SeparationDate = separationDate, // Accepts null when clearing/removing the date
                        SeparationReason = finalReason,
                        SeparatedBy = User.Identity?.Name ?? "System",
                        CreatedAt = DateTime.Now
                    };
                    _context.EmployeeSeparationHistories.Add(newHistory);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Invalid Employee Code format." });
                }
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return Json(new { success = false, message = "Database Error: " + (ex.InnerException?.Message ?? ex.Message) });
            }
        }

        [HttpGet]
        public async Task<IActionResult> SeparationHistory()
        {
            var baseQuery = from h in _context.EmployeeSeparationHistories
                            join p in _context.PmsPersonnelInformations on h.HrisId equals p.HrisId
                            select new
                            {
                                h.SeparationLogId,
                                h.HrisId,
                                EmployeeId = p.EmployeeId ?? "",
                                GivenName = p.GivenName ?? "",
                                Surname = p.Surname ?? "",
                                h.SeparationDate,
                                h.SeparationReason,
                                h.SeparatedBy,
                                h.CreatedAt
                            };

            var historyData = await baseQuery
                .OrderByDescending(h => h.SeparationLogId)
                .ToListAsync();

            var hrisIds = historyData.Select(x => x.HrisId).ToList();
            var occupations = await _context.TimekeepingOccupationDetails
                .Where(o => hrisIds.Contains(o.HrisId))
                .ToListAsync();

            var divisions = await _context.TimekeepingDivisions.ToListAsync();

            var occupationDict = occupations
                .GroupBy(o => o.HrisId)
                .ToDictionary(g => g.Key, g => g.FirstOrDefault());

            var divisionDict = divisions.ToDictionary(d => d.Id, d => d.Sname);

            var historyItems = historyData.Select(x =>
            {
                occupationDict.TryGetValue(x.HrisId, out var occ);

                string deptName = "Unassigned";
                if (occ != null && occ.Division.HasValue && divisionDict.TryGetValue(occ.Division.Value, out var sname))
                {
                    deptName = sname ?? "Unassigned";
                }

                return new EmployeeSeparationHistoryViewModel
                {
                    SeparationLogId = x.SeparationLogId,
                    EmployeeId = string.IsNullOrEmpty(x.EmployeeId) ? "N/A" : x.EmployeeId,
                    EmployeeCode = x.HrisId.ToString(),
                    FullName = (x.GivenName + " " + x.Surname).Trim(),
                    Department = deptName,
                    Position = occ != null && occ.Position != null ? occ.Position.ToString() : "Unassigned",
                    SeparationDate = x.SeparationDate,
                    SeparationReason = x.SeparationReason,
                    SeparatedBy = x.SeparatedBy ?? "System",
                    CreatedAt = x.CreatedAt
                };
            }).ToList();

            return View(historyItems);
        }
    }
}