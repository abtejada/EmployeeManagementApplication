using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingLeaveOff
{
    public int Id { get; set; }

    public DateOnly CancelDate { get; set; }

    public string EmpId { get; set; } = null!;

    public bool Deleted { get; set; }

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }
}
