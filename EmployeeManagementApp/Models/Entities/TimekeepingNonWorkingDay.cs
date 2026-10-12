using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingNonWorkingDay
{
    public int NwdId { get; set; }

    public string NwdDesc { get; set; } = null!;

    public string NwdType { get; set; } = null!;

    public DateOnly NwdDay { get; set; }

    public TimeOnly? NwdCut { get; set; }

    public bool? Deleted { get; set; }

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }
}
