using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingTempUndertime
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public decimal Undertime { get; set; }

    public TimeOnly TimeEquivalent { get; set; }

    public DateOnly Date { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatebBy { get; set; }
}
