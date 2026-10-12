using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingLeaveBal
{
    public int Id { get; set; }

    public int EmpNum { get; set; }

    public decimal GainVl { get; set; }

    public decimal GainSl { get; set; }

    public DateOnly MonthYear { get; set; }
}
