using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class RecruitmentPlantillium
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? PlantiliaItemNumber { get; set; }

    public int? Sg { get; set; }

    public string OriginalLoc { get; set; } = null!;

    public string? AssignedLoc { get; set; }

    public string? Code { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public bool Deleted { get; set; }
}
