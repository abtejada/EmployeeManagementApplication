using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingMonthlySummaryLeave
{
    public int HrisId { get; set; }

    public decimal? CurrentVl { get; set; }

    public decimal? CurrentSl { get; set; }

    public int? CurrentPl { get; set; }

    public int? CurrentFl { get; set; }

    public int? CurrentSoloParent { get; set; }

    public DateOnly DateComputed { get; set; }
}
