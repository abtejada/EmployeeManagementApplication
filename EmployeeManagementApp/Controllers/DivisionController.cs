using EmployeeManagementApp.Models;
using EmployeeManagementApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

[Route("Division")]
public class DivisionController : Controller
{
    private readonly PMMContext _context;

    public DivisionController(PMMContext context)
    {
        _context = context;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var divisions = await _context.TimekeepingDivisions.ToListAsync();
        var personnel = await _context.PmsPersonnelInformations.ToListAsync();

        var personnelSelectList = personnel.Select(p => new SelectListItem
        {
            Value = p.HrisId.ToString(),
            Text = $"{p.Surname}, {p.GivenName} ({p.EmployeeId ?? "No ID"})"
        }).ToList();

        var viewModelList = divisions.Select(d =>
        {
            var head = personnel.FirstOrDefault(p => p.HrisId == d.HeadHrisId);
            string headName = head != null ? $"{head.GivenName} {head.Surname}".Trim() : "Unassigned";

            // Resolve Alternate Head name using AlternateHead integer ID lookup
            var altHead = personnel.FirstOrDefault(p => p.HrisId == d.AlternateHead);
            string altName = altHead != null ? $"{altHead.GivenName} {altHead.Surname}".Trim() : "Unassigned";

            return new DivisionManagementViewModel
            {
                Id = d.Id,
                Name = d.Name ?? "", 
                Sname = d.Sname ?? "",
                Status = d.Status,
                DivIdSuperior = d.DivIdSuperior ?? 0,
                HeadHrisId = d.HeadHrisId,
                HeadName = headName,
                Designation = d.Designation ?? "",
                AlternateHead = d.AlternateHead,
                AlternateHeadDesignation = d.AlternateHeadDesignation ?? "",
                AlternateHeadName = altName,
                OfficeLevel = d.OfficeLevel ?? 0,
                PersonnelOptions = personnelSelectList
            };
        }).ToList();

        ViewBag.PersonnelList = personnelSelectList;
        return View(viewModelList);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update([FromForm] DivisionManagementViewModel model)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var division = await _context.TimekeepingDivisions.FindAsync(model.Id);
            if (division == null)
            {
                return Json(new { success = false, message = "Division record not found." });
            }

            string currentUserName = User.Identity?.Name ?? "System";
            var changes = new List<string>();

            // Compare each field and track changes
            if ((division.Name ?? string.Empty) != (model.Name ?? string.Empty))
            {
                changes.Add($"Division Name from '{division.Name}' to '{model.Name}'");
                division.Name = model.Name;
            }

            if ((division.Sname ?? string.Empty) != (model.Sname ?? string.Empty))
            {
                changes.Add($"Short Name from '{division.Sname}' to '{model.Sname}'");
                division.Sname = model.Sname;
            }

            if (division.Status != model.Status)
            {
                string oldStatusVal = division.Status.HasValue ? (division.Status.Value ? "Active" : "Inactive") : "None";
                string newStatusVal = model.Status.HasValue ? (model.Status.Value ? "Active" : "Inactive") : "None";

                changes.Add($"Status from '{oldStatusVal}' to '{newStatusVal}'");
                division.Status = model.Status;
            }

            // 2. Office Level (string)
            if ((division.OfficeLevel) != (model.OfficeLevel))
            {
                changes.Add($"Office Level from '{division.OfficeLevel}' to '{model.OfficeLevel}'");
                division.OfficeLevel = model.OfficeLevel;
            }

            if ((division.Designation ?? string.Empty) != (model.Designation ?? string.Empty))
            {
                changes.Add($"Designation from '{division.Designation}' to '{model.Designation}'");
                division.Designation = model.Designation;
            }

            if (division.HeadHrisId != model.HeadHrisId)
            {
                changes.Add($"Head HRIS ID from '{division.HeadHrisId}' to '{model.HeadHrisId}'");
                division.HeadHrisId = model.HeadHrisId;
            }

            if ((division.AlternateHeadDesignation ?? string.Empty) != (model.AlternateHeadDesignation ?? string.Empty))
            {
                changes.Add($"Alternate Head Designation from '{division.AlternateHeadDesignation}' to '{model.AlternateHeadDesignation}'");
                division.AlternateHeadDesignation = model.AlternateHeadDesignation;
            }

            // If no fields changed, return early
            if (!changes.Any())
            {
                return Json(new { success = true, message = "No changes detected in division details." });
            }

            // Consolidate all changes into a formatted string with line breaks and color styling
            string formattedChanges = string.Join(",<br />", changes.Select(c =>
                c.Replace("from '", "from '<span class=\"text-danger\">")
                 .Replace("' to '", "</span>' to '<span class=\"text-success\">")
                 .Replace("'", "</span>'")
            ));

            string consolidatedDescription = "Updated " + formattedChanges + ".";

            var auditLog = new DivisionAuditLog
            {
                DivisionId = division.Id,
                DivisionName = division.Name ?? "Unknown",
                Description = consolidatedDescription,
                ModifiedBy = currentUserName,
                UpdatedAt = DateTime.Now
            };

            _context.DivisionAuditLogs.Add(auditLog);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();

            return Json(new { success = true, message = "Division updated successfully and recorded in audit log." });
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            return Json(new { success = false, message = ex.Message });
        }
    }

    [HttpGet("AuditHistory")]
    public async Task<IActionResult> AuditHistory()
    {
        var logs = await _context.DivisionAuditLogs
            .OrderByDescending(l => l.UpdatedAt)
            .Select(l => new DivisionAuditLogViewModel
            {
                AuditId = l.AuditId,
                DivisionId = l.DivisionId,
                DivisionName = l.DivisionName,
                Description = l.Description,
                ModifiedBy = l.ModifiedBy,
                UpdatedAt = l.UpdatedAt
            })
            .ToListAsync();

        return View("DivisionAuditHistory", logs);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromForm] DivisionManagementViewModel model)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                return Json(new { success = false, message = "Division Name is required." });
            }

            // Check if the unique Division Name or Short Name already exists
            bool exists = await _context.TimekeepingDivisions
                .AnyAsync(d => d.Name == model.Name || (!string.IsNullOrEmpty(model.Sname) && d.Sname == model.Sname));

            if (exists)
            {
                return Json(new { success = false, message = "A division with this Name or Short Name already exists." });
            }

            var newDivision = new TimekeepingDivision
            {
                Name = model.Name,
                Sname = model.Sname,
                Status = model.Status,
                DivIdSuperior = model.DivIdSuperior,
                HeadHrisId = model.HeadHrisId,
                Designation = model.Designation,
                AlternateHead = model.AlternateHead ?? 0,
                AlternateHeadDesignation = model.AlternateHeadDesignation,
                OfficeLevel = model.OfficeLevel
            };

            _context.TimekeepingDivisions.Add(newDivision);
            await _context.SaveChangesAsync(); // Saves first so newDivision.Id is generated

            string currentUserName = User.Identity?.Name ?? "System";

            // Build creation details string with green styling for initial values
            var details = new List<string>
        {
            $"Division Name: <span class=\"text-success\">'{newDivision.Name}'</span>",
            $"Short Name: <span class=\"text-success\">'{newDivision.Sname}'</span>",
            $"Status: <span class=\"text-success\">'{newDivision.Status}'</span>",
            $"Office Level: <span class=\"text-success\">'{newDivision.OfficeLevel}'</span>",
            $"Designation: <span class=\"text-success\">'{newDivision.Designation}'</span>"
        };

            string consolidatedDescription = "Created new division with " + string.Join(",<br />", details) + ".";

            var auditLog = new DivisionAuditLog
            {
                DivisionId = newDivision.Id,
                DivisionName = newDivision.Name ?? "Unknown",
                Description = consolidatedDescription,
                ModifiedBy = currentUserName,
                UpdatedAt = DateTime.Now
            };

            _context.DivisionAuditLogs.Add(auditLog);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();

            return Json(new { success = true, message = "New division created successfully and recorded in audit log." });
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            return Json(new { success = false, message = ex.Message });
        }
    }
}