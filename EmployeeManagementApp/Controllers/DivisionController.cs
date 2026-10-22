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
        var division = await _context.TimekeepingDivisions.FindAsync(model.Id);
        if (division == null)
        {
            return Json(new { success = false, message = "Division record not found." });
        }

        // NOTE: Name and Sname are unique identifiers and intentionally excluded from updates.

        division.Status = model.Status;
        division.DivIdSuperior = model.DivIdSuperior;
        division.HeadHrisId = model.HeadHrisId;
        division.Designation = model.Designation;
        division.AlternateHead = model.AlternateHead ?? 0;
        division.AlternateHeadDesignation = model.AlternateHeadDesignation;
        division.OfficeLevel = model.OfficeLevel;

        await _context.SaveChangesAsync();
        return Json(new { success = true, message = "Division organizational structure updated successfully." });
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromForm] DivisionManagementViewModel model)
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
        await _context.SaveChangesAsync();

        return Json(new { success = true, message = "New division created successfully." });
    }
}