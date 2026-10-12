using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsOccupationWorkexp
{
    public int WExpId { get; set; }

    public int HrisId { get; set; }

    public string? PositionTitle { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? MonthlySalary { get; set; }

    public int? SalaryGrade { get; set; }

    public int? StepIncrement { get; set; }

    public string? Status { get; set; }

    public bool? GovtService { get; set; }

    public int? HoursWeek { get; set; }

    public string? Company { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? MajorDuties { get; set; }

    public string? ReasonLeave { get; set; }
}
