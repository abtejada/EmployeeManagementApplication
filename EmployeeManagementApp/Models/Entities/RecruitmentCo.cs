using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class RecruitmentCo
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? Sg { get; set; }

    public string OriginalLoc { get; set; } = null!;

    public string? AssignedLoc { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public bool Deleted { get; set; }

    public decimal? Salary { get; set; }

    public decimal? Premium20 { get; set; }

    public string? Remarks { get; set; }
}
