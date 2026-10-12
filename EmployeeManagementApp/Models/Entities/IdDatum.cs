using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdDatum
{
    public string? HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? ExtensionName { get; set; }

    public string? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public string? Sex { get; set; }

    public string? Height { get; set; }

    public string? Weight { get; set; }

    public string? BloodType { get; set; }

    public string? GsisId { get; set; }

    public string? PhilhealthId { get; set; }

    public string? SssId { get; set; }

    public string? TinId { get; set; }

    public string? ResidentialNumber { get; set; }

    public string? ResidentialStreet { get; set; }

    public string? ResidentialBrgy { get; set; }

    public string? ResidentialCtyMnicplty { get; set; }

    public string? ResidentialProvince { get; set; }

    public string? NamePerson { get; set; }

    public string? ContactNumber { get; set; }

    public string? Relationship { get; set; }

    public string? IceNumber { get; set; }

    public string? IceStreet { get; set; }

    public string? IceBrgy { get; set; }

    public string? IceCtyMnicplty { get; set; }

    public string? IceProvince { get; set; }

    public byte[]? IdImage { get; set; }

    public byte[]? SignatureImage { get; set; }

    public byte[]? Rthumb { get; set; }

    public byte[]? Lthumb { get; set; }

    public string? IdentifyingMark { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedUserId { get; set; }

    public byte[]? IdFingerPrint { get; set; }

    public string? IdFingerName { get; set; }

    public int Expr1 { get; set; }

    public string? Position { get; set; }
}
