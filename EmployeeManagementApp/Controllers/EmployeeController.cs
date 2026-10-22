using EmployeeManagementApp.Models;
using EmployeeManagementApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly PMMContext _context;

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
            var divisionList = await divisionQuery.ToListAsync();

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            var employeeDirectory = personnelList.Select(p =>
            {
                var occ = occupationList.FirstOrDefault(o => o.HrisId.ToString().Trim() == p.HrisId.ToString().Trim());

                // Find division from TimekeepingDivisions where division.Id matches occupation.Division
                var div = (occ != null && occ.Division.HasValue)
                    ? divisionList.FirstOrDefault(d => d.Id == occ.Division.Value)
                    : null;

                string hrisIdStr = p.HrisId.ToString().Trim();

                // Division short name (Sname) mapping
                string divShortName = (div != null && !string.IsNullOrEmpty(div.Sname)) ? div.Sname : "Unassigned";

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

                    // Name components & Prefix/Suffix mapping
                    Prefix = p.Prefix,
                    GivenName = p.GivenName ?? "",
                    MiddleName = p.MiddleName,
                    Surname = p.Surname ?? "",
                    ExtensionName = p.ExtensionName,
                    Suffix = p.Suffix,

                    Department = divShortName,
                    DivisionShortName = divShortName, // Mapped from TimekeepingDivisions.Sname
                    Position = occ != null && occ.Position != null ? occ.Position.ToString() : "Unassigned",
                    IsActive = isActive,

                    // Separation details & remarks mapping
                    SeparationDateFormatted = sepDateFormatted,
                    SeparationReason = occ?.SeparationReason ?? "",
                    SeparationRemarks = occ?.SeparationRemarks ?? "",
                    HasExistingSeparation = hasSeparationValue
                };
            }).ToList();

            return View(employeeDirectory);
        }

        [HttpGet]
        public async Task<IActionResult> SeparationHistory()
        {
            var historyList = await _context.EmployeeSeparationHistories.ToListAsync();
            var personnelList = await _context.PmsPersonnelInformations.ToListAsync();
            var occupationList = await _context.TimekeepingOccupationDetails.ToListAsync();
            var divisionList = await _context.TimekeepingDivisions.ToListAsync();

            var viewModelList = historyList.Select(h =>
            {
                var p = personnelList.FirstOrDefault(x => x.HrisId == h.HrisId);
                var occ = occupationList.FirstOrDefault(x => x.HrisId == h.HrisId);
                var div = (occ != null && occ.Division.HasValue)
                    ? divisionList.FirstOrDefault(d => d.Id == occ.Division.Value)
                    : null;

                string fullName = p != null
                    ? $"{p.Prefix ?? ""} {p.GivenName ?? ""} {p.MiddleName ?? ""} {p.Surname ?? ""} {p.ExtensionName ?? ""}".Trim().Replace("  ", " ")
                    : "N/A";

                string divName = div != null && !string.IsNullOrEmpty(div.Sname) ? div.Sname : "Unassigned";

                return new EmployeeSeparationHistoryViewModel
                {
                    SeparationLogId = h.SeparationLogId,
                    EmployeeId = p?.EmployeeId ?? "N/A",
                    FullName = fullName,
                    Department = divName,
                    Position = occ != null && occ.Position != null ? occ.Position.ToString() : "Unassigned",
                    SeparationDate = h.SeparationDate,
                    SeparationReason = h.SeparationReason,
                    SeparationRemarks = h.SeparationRemarks,
                    SeparatedBy = h.SeparatedBy ?? "System",
                    CreatedAt = h.CreatedAt
                };
            }).OrderByDescending(x => x.CreatedAt).ToList();

            return View(viewModelList);
        }

        [HttpPost]
        [Route("Employee/UpdateProfile")] // Or just [HttpPost] depending on your routing setup
        public async Task<IActionResult> UpdateProfile([FromForm] EmployeeUpdateViewModel model)
        {
            try
            {
                if (!int.TryParse(model.EmployeeCode, out int hrisId))
                {
                    return Json(new { success = false, message = "Invalid Employee Code format." });
                }

                var personnel = await _context.PmsPersonnelInformations
                    .FirstOrDefaultAsync(p => p.HrisId == hrisId);

                if (personnel == null)
                {
                    return Json(new { success = false, message = "Employee record not found." });
                }

                // Update profile fields
                personnel.Prefix = model.Prefix;
                personnel.GivenName = model.GivenName;
                personnel.MiddleName = model.MiddleName;
                personnel.Surname = model.Surname;
                personnel.ExtensionName = model.ExtensionName;
                personnel.Suffix = model.Suffix; // Save Suffix separately

                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Employee profile updated successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("Employee/UpdateSeparation")]
        public async Task<IActionResult> UpdateSeparation([FromForm] EmployeeUpdateViewModel model)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (!int.TryParse(model.EmployeeCode, out int hrisId))
                {
                    return Json(new { success = false, message = "Invalid Employee Code format." });
                }

                DateTime? sqlSeparationDate = model.SeparationDate?.ToDateTime(TimeOnly.MinValue);
                string currentUserName = User.Identity?.Name ?? "System";

                // Validate that Reason and Remarks are provided regardless of whether setting or clearing separation
                if (string.IsNullOrWhiteSpace(model.SeparationReason))
                {
                    return Json(new { success = false, message = "Separation reason is required." });
                }

                if (string.IsNullOrWhiteSpace(model.SeparationRemarks))
                {
                    return Json(new { success = false, message = "Separation remarks are required." });
                }

                // 1. If Clearing Separation (Restoring Active Status)
                if (!sqlSeparationDate.HasValue)
                {
                    // Reset lookup fields in active occupation details
                    var occupationDetail = await _context.TimekeepingOccupationDetails
                        .FirstOrDefaultAsync(o => o.HrisId == hrisId);

                    if (occupationDetail != null)
                    {
                        occupationDetail.SeparationDate = null;
                        occupationDetail.SeparationReason = null;
                        occupationDetail.SeparationRemarks = null;
                    }

                    // Record clearance audit trail using user's inputted reason & remarks
                    var clearHistory = new EmployeeSeparationHistory
                    {
                        HrisId = hrisId,
                        SeparationDate = null,
                        SeparationReason = $"Cleared / Restored ({model.SeparationReason})", // Prefixes with action state
                        SeparationRemarks = model.SeparationRemarks,                         // User's custom remarks
                        SeparatedBy = currentUserName,
                        CreatedAt = DateTime.Now
                    };
                    _context.EmployeeSeparationHistories.Add(clearHistory);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return Json(new { success = true, message = "Separation cleared successfully. Employee status restored to active." });
                }

                // 2. If Setting / Updating Separation
                var newHistory = new EmployeeSeparationHistory
                {
                    HrisId = hrisId,
                    SeparationDate = DateOnly.FromDateTime(sqlSeparationDate.Value),
                    SeparationReason = model.SeparationReason,
                    SeparationRemarks = model.SeparationRemarks,
                    SeparatedBy = currentUserName,
                    CreatedAt = DateTime.Now
                };
                _context.EmployeeSeparationHistories.Add(newHistory);

                var occDetail = await _context.TimekeepingOccupationDetails
                    .FirstOrDefaultAsync(o => o.HrisId == hrisId);

                if (occDetail != null)
                {
                    occDetail.SeparationDate = sqlSeparationDate;
                    occDetail.SeparationReason = model.SeparationReason;
                    occDetail.SeparationRemarks = model.SeparationRemarks;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Json(new { success = true, message = "Employee separation details updated successfully." });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}