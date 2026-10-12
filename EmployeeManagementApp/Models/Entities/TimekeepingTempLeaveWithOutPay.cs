using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingTempLeaveWithOutPay
{
    public int LeaveId { get; set; }

    public string EmpId { get; set; } = null!;

    public string? RefNo { get; set; }

    public DateOnly LFrom { get; set; }

    public DateOnly LTo { get; set; }

    public int Type { get; set; }

    public int Deleted { get; set; }

    public string Remarks { get; set; } = null!;

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }

    public string Origin { get; set; } = null!;
}
