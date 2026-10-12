using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingOfficialBusiness
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int LoId { get; set; }

    public int LoDetailsId { get; set; }

    public bool Deleted { get; set; }

    public bool? Verified { get; set; }

    public int? AmendedId { get; set; }

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }

    public string? Origin { get; set; }
}
