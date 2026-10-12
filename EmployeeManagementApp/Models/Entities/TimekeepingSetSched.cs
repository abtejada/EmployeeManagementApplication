using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingSetSched
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public string? Mon { get; set; }

    public string? Tue { get; set; }

    public string? Wed { get; set; }

    public string? Thu { get; set; }

    public string? Fri { get; set; }

    public bool IsDefault { get; set; }

    public bool? FixSched { get; set; }

    public bool? IsFlexi { get; set; }

    public bool? ExcludeMandoSched { get; set; }

    public bool Status { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;
}
