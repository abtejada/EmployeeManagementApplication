using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelEligibility
{
    public int CivilId { get; set; }

    public int HrisId { get; set; }

    public string? EligibilityName { get; set; }

    public string? Rating { get; set; }

    public DateOnly? ConferedDate { get; set; }

    public string? ConferedPlace { get; set; }

    public string? LicenseId { get; set; }

    public DateOnly? ValiditiyDate { get; set; }
}
