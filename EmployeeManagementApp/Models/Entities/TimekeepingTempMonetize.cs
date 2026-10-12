using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingTempMonetize
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int MonitizeLeave { get; set; }

    public int TypeLeave { get; set; }

    public string? Remarks { get; set; }

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }

    public bool? Deleted { get; set; }
}
