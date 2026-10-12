using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class EmployeeRecord
{
    public int HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? ExtensionName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? CivilStatus { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? BloodType { get; set; }

    public string? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? NamePerson { get; set; }

    public string? Mobilenum { get; set; }

    public byte[]? IdImage { get; set; }

    public int? Division { get; set; }

    public string? Name { get; set; }
}
