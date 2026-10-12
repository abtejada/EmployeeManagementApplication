using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelLearningdevelopment
{
    public int LdId { get; set; }

    public int? HrisId { get; set; }

    public string? Program { get; set; }

    public string? Conducted { get; set; }

    public string? TypeLd { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Hours { get; set; }
}
