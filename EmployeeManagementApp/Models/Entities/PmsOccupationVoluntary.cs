using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsOccupationVoluntary
{
    public int Id { get; set; }

    public int? HrisId { get; set; }

    public string? Organization { get; set; }

    public string? Address { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public int? Hours { get; set; }

    public string? Position { get; set; }
}
