using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingLeaveItem
{
    public int Id { get; set; }

    public string LeaveName { get; set; } = null!;

    public int? DaysUse { get; set; }

    public bool Active { get; set; }

    public int? ApplicableTo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? ModifiedInfo { get; set; }

    public string? Code { get; set; }
}
