using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingSchedHistory
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public DateOnly DateEffectivity { get; set; }

    public int? Mon { get; set; }

    public int? Tue { get; set; }

    public int? Wed { get; set; }

    public int? Thu { get; set; }

    public int? Fri { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
