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
        public async Task<IActionResult> Index(string? searchTerm, string? statusFilter, int? pageNumber)
        {
            int pageSize = 10;
            int pageIndex = pageNumber ?? 1;

            bool hasSearched = !string.IsNullOrWhiteSpace(searchTerm);
            ViewData["HasSearched"] = hasSearched;

            // If user hasn't searched yet, return an empty list immediately
            if (!hasSearched)
            {
                ViewData["CurrentPage"] = 1;
                ViewData["TotalPages"] = 1;
                ViewData["CurrentFilter"] = "";
                ViewData["CurrentStatus"] = statusFilter ?? "All";
                return View(new List<EmployeeDirectoryViewModel>());
            }

            var personnelQuery = _context.PmsPersonnelInformations.AsQueryable();
            var occupationQuery = _context.TimekeepingOccupationDetails.AsQueryable();
            var divisionQuery = _context.TimekeepingDivisions.AsQueryable();

            // Search filter (Removed HRIS ID search parameter, keeping name & employee ID)
            var term = searchTerm.Trim();
            personnelQuery = personnelQuery.Where(p =>
                p.GivenName.Contains(term) ||
                p.Surname.Contains(term) ||
                p.EmployeeId.Contains(term));

            var personnelList = await personnelQuery.ToListAsync();
            var occupationList = await occupationQuery.ToListAsync();
            var divisionList = await divisionQuery.ToListAsync();

            var employeeDirectory = personnelList.Select(p =>
            {
                var occ = occupationList.FirstOrDefault(o => o.HrisId.ToString().Trim() == p.HrisId.ToString().Trim());

                var div = (occ != null && occ.Division.HasValue)
                    ? divisionList.FirstOrDefault(d => d.Id == occ.Division.Value)
                    : null;

                string hrisIdStr = p.HrisId.ToString().Trim() ?? "";
                string deptName = div != null ? div.Sname : "Unassigned";

                // Get today's date for comparison
                DateOnly today = DateOnly.FromDateTime(DateTime.Today);

                bool hasSeparationValue = occ != null && occ.SeparationDate.HasValue;
                DateOnly? sepDateOnly = hasSeparationValue ? DateOnly.FromDateTime(occ.SeparationDate.Value) : (DateOnly?)null;

                // An employee is considered "Active" if they have no separation date, 
                // or if their separation date is today or in the future.
                // They are only "Separated" if the separation date has actually passed (is strictly in the past).
                bool isCurrentlySeparated = sepDateOnly.HasValue && sepDateOnly.Value <= today;
                bool isActive = !isCurrentlySeparated;

                string sepDateFormatted = hasSeparationValue ? sepDateOnly.Value.ToString("yyyy-MM-dd") : "";

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
                    HasExistingSeparation = hasSeparationValue // Keeps track if a date exists in input for modal mode
                };
            }).AsQueryable();

            int totalItems = employeeDirectory.Count();
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            if (totalPages > 0 && pageIndex > totalPages) pageIndex = totalPages;
            if (pageIndex < 1) pageIndex = 1;

            var paginatedItems = employeeDirectory
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewData["CurrentPage"] = pageIndex;
            ViewData["TotalPages"] = totalPages > 0 ? totalPages : 1;
            ViewData["CurrentFilter"] = searchTerm;
            ViewData["CurrentStatus"] = statusFilter ?? "All";

            return View(paginatedItems);
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
        public async Task<IActionResult> SeparationHistory(string? searchTerm, int? pageNumber)
        {
            int pageSize = 10;
            int pageIndex = pageNumber ?? 1;

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

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var term = searchTerm.Trim();
                baseQuery = baseQuery.Where(s =>
                    (s.GivenName + " " + s.Surname).Contains(term) ||
                    s.EmployeeId.Contains(term) ||
                    s.HrisId.ToString().Contains(term));
            }

            var totalItems = await baseQuery.CountAsync();
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            if (totalPages > 0 && pageIndex > totalPages) pageIndex = totalPages;
            if (pageIndex < 1) pageIndex = 1;

            var pagedData = await baseQuery
                .OrderByDescending(h => h.SeparationLogId)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var hrisIds = pagedData.Select(x => x.HrisId).ToList();
            var occupations = await _context.TimekeepingOccupationDetails
                .Where(o => hrisIds.Contains(o.HrisId))
                .ToListAsync();

            // Fetch all divisions so we can map sname in separation history too
            var divisions = await _context.TimekeepingDivisions.ToListAsync();

            var occupationDict = occupations
                .GroupBy(o => o.HrisId)
                .ToDictionary(g => g.Key, g => g.FirstOrDefault());

            var divisionDict = divisions.ToDictionary(d => d.Id, d => d.Sname);

            var paginatedItems = pagedData.Select(x =>
            {
                occupationDict.TryGetValue(x.HrisId, out var occ);

                // Translate division ID to sname short name
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
                    Department = deptName, // Now shows clean sname instead of raw ID number
                    Position = occ != null && occ.Position != null ? occ.Position.ToString() : "Unassigned",
                    SeparationDate = x.SeparationDate,
                    SeparationReason = x.SeparationReason,
                    SeparatedBy = x.SeparatedBy ?? "System",
                    CreatedAt = x.CreatedAt
                };
            }).ToList();

            ViewData["CurrentPage"] = pageIndex;
            ViewData["TotalPages"] = totalPages > 0 ? totalPages : 1;
            ViewData["CurrentFilter"] = searchTerm;

            return View(paginatedItems);
        }
    }
}