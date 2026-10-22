using EmployeeManagementApp.Models;
using EmployeeManagementApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagementApp.Controllers
{
    [Authorize]
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
        [Route("Employee/UpdateProfile")]
        public async Task<IActionResult> UpdateProfile([FromForm] EmployeeUpdateViewModel model)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
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

                string currentUserName = User.Identity?.Name ?? "System";
                var changes = new List<string>();

                // Compare and track each field
                if ((personnel.Prefix ?? string.Empty) != (model.Prefix ?? string.Empty))
                {
                    changes.Add($"Prefix from '{personnel.Prefix}' to '{model.Prefix}'");
                    personnel.Prefix = model.Prefix;
                }

                if ((personnel.GivenName ?? string.Empty) != (model.GivenName ?? string.Empty))
                {
                    changes.Add($"Given Name from '{personnel.GivenName}' to '{model.GivenName}'");
                    personnel.GivenName = model.GivenName;
                }

                if ((personnel.MiddleName ?? string.Empty) != (model.MiddleName ?? string.Empty))
                {
                    changes.Add($"Middle Name from '{personnel.MiddleName}' to '{model.MiddleName}'");
                    personnel.MiddleName = model.MiddleName;
                }

                if ((personnel.Surname ?? string.Empty) != (model.Surname ?? string.Empty))
                {
                    changes.Add($"Surname from '{personnel.Surname}' to '{model.Surname}'");
                    personnel.Surname = model.Surname;
                }

                if ((personnel.ExtensionName ?? string.Empty) != (model.ExtensionName ?? string.Empty))
                {
                    changes.Add($"Extension Name from '{personnel.ExtensionName}' to '{model.ExtensionName}'");
                    personnel.ExtensionName = model.ExtensionName;
                }

                if ((personnel.Suffix ?? string.Empty) != (model.Suffix ?? string.Empty))
                {
                    changes.Add($"Suffix from '{personnel.Suffix}' to '{model.Suffix}'");
                    personnel.Suffix = model.Suffix;
                }

                // If no fields were modified, return early
                if (!changes.Any())
                {
                    return Json(new { success = true, message = "No changes detected in profile details." });
                }

                // Consolidate all changes into a formatted string with line breaks and color styling
                string formattedChanges = string.Join(",<br />", changes.Select(c =>
                    // Assuming 'c' is built as "FieldName from 'Old' to 'New'"
                    // We can replace the quotes with colored spans
                    c.Replace("from '", "from '<span class=\"text-danger\">").Replace("' to '", "</span>' to '<span class=\"text-success\">").Replace("'", "</span>'")
                ));

                string consolidatedDescription = "Updated " + formattedChanges + ".";
                // Insert exactly ONE audit log record
                var auditLog = new EmployeeProfileAuditLog
                {
                    HrisId = hrisId,
                    EmployeeId = personnel.EmployeeId ?? model.EmployeeCode,
                    Description = consolidatedDescription,
                    ModifiedBy = currentUserName,
                    UpdatedAt = DateTime.Now
                };

                _context.EmployeeProfileAuditLogs.Add(auditLog);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Json(new { success = true, message = "Profile updated successfully and recorded in audit trail." });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        [Route("Employee/AuditHistory")]
        public async Task<IActionResult> AuditHistory()
        {
            var logs = await _context.EmployeeProfileAuditLogs
                .OrderByDescending(l => l.UpdatedAt)
                .Select(l => new EmployeeProfileAuditLogViewModel
                {
                    AuditId = l.AuditId,
                    EmployeeId = l.EmployeeId,
                    Description = l.Description, // Updated to map the single consolidated description
                    ModifiedBy = l.ModifiedBy,
                    UpdatedAt = l.UpdatedAt
                })
                .ToListAsync();

            return View("ProfileAuditHistory", logs);
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

                // This automatically reads the formatted name from the authentication cookie cookie claims!
                string currentUserName = User.Identity?.Name ?? "System";

                // Validate required fields
                if (string.IsNullOrWhiteSpace(model.SeparationReason))
                {
                    return Json(new { success = false, message = "Separation reason is required." });
                }

                if (string.IsNullOrWhiteSpace(model.SeparationRemarks))
                {
                    return Json(new { success = false, message = "Separation remarks are required." });
                }

                // If clearing separation (Restoring active status)
                if (!sqlSeparationDate.HasValue)
                {
                    var occupationDetail = await _context.TimekeepingOccupationDetails
                        .FirstOrDefaultAsync(o => o.HrisId == hrisId);

                    if (occupationDetail != null)
                    {
                        occupationDetail.SeparationDate = null;
                        occupationDetail.SeparationReason = null;
                        occupationDetail.SeparationRemarks = null;
                    }

                    // Records clearance log stamped with the logged-in user
                    var clearHistory = new EmployeeSeparationHistory
                    {
                        HrisId = hrisId,
                        SeparationDate = null,
                        SeparationReason = $"Cleared / Restored ({model.SeparationReason})",
                        SeparationRemarks = model.SeparationRemarks,
                        SeparatedBy = currentUserName, // Captures "Full Name (Employee ID)"
                        CreatedAt = DateTime.Now
                    };
                    _context.EmployeeSeparationHistories.Add(clearHistory);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return Json(new { success = true, message = "Separation cleared successfully. Employee status restored to active." });
                }

                // If setting/updating separation, assign the code block you provided:
                var newHistory = new EmployeeSeparationHistory
                {
                    HrisId = hrisId,
                    SeparationDate = DateOnly.FromDateTime(sqlSeparationDate.Value),
                    SeparationReason = model.SeparationReason,
                    SeparationRemarks = model.SeparationRemarks,
                    SeparatedBy = currentUserName, // Automatically logs "Full Name (Employee ID)"
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