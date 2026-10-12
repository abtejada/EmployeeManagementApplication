using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelInformation
{
    public int HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? ExtensionName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public string? Sex { get; set; }

    public string? CivilStatus { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? BloodType { get; set; }

    public string? GsisId { get; set; }

    public string? PagibigId { get; set; }

    public string? PhilhealthId { get; set; }

    public string? SssId { get; set; }

    public string? TinId { get; set; }

    public bool? CitizenshipDual { get; set; }

    public bool? CitizenshipBirth { get; set; }

    public string? CitizenshipCountry { get; set; }

    public string? ResidentialRegion { get; set; }

    public string? ResidentialProvince { get; set; }

    public string? ResidentialCtyMnicplty { get; set; }

    public string? ResidentialBrgy { get; set; }

    public string? ResidentialNumber { get; set; }

    public string? ResidentialStreet { get; set; }

    public int? ResidentialZipcode { get; set; }

    public string? PermanentRegion { get; set; }

    public string? PermanentProvince { get; set; }

    public string? PermanentCtyMnicplty { get; set; }

    public string? PermanentBrgy { get; set; }

    public string? PermanentNumber { get; set; }

    public string? PermanentStreet { get; set; }

    public int? PermanentZipcode { get; set; }

    public string? NamePerson { get; set; }

    public string? ContactNumber { get; set; }

    public string? Relationship { get; set; }

    public string? IceRegion { get; set; }

    public string? IceProvince { get; set; }

    public string? IceCtyMnicplty { get; set; }

    public string? IceBrgy { get; set; }

    public string? IceNumber { get; set; }

    public string? IceStreet { get; set; }

    public int? IceZipcode { get; set; }

    public string? Telephonenum { get; set; }

    public string? Mobilenum { get; set; }

    public string? Email { get; set; }
}
