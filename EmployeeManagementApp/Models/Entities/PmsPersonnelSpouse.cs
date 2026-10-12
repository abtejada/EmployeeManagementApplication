using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelSpouse
{
    public int HrisId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? ExtensionName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Occupation { get; set; }

    public string? EmployerName { get; set; }

    public string? EmployerAddress { get; set; }

    public string? ContactNumber { get; set; }
}
