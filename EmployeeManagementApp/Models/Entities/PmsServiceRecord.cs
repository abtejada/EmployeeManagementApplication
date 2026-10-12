using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsServiceRecord
{
    public int Servicerecordid { get; set; }

    public string? Employeeid { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public string? Position { get; set; }

    public int? AnnualSalary { get; set; }

    public string? Status { get; set; }

    public string? Agency { get; set; }

    public DateOnly? SeparationDate { get; set; }

    public string? SeparationCause { get; set; }
}
