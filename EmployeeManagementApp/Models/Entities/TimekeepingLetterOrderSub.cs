using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingLetterOrderSub
{
    public int Id { get; set; }

    public int LoId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int ObType { get; set; }

    public string RefNo { get; set; } = null!;

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public string? Details { get; set; }

    public string? Days { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public bool Deleted { get; set; }

    public virtual TimekeepingLetterOrder Lo { get; set; } = null!;
}
