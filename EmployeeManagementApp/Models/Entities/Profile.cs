using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class Profile
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

    public string? GsisId { get; set; }

    public string? PagibigId { get; set; }

    public string? PhilhealthId { get; set; }

    public string? SssId { get; set; }

    public string? TinId { get; set; }

    public bool? Pwd { get; set; }

    public bool? SoloParent { get; set; }

    public DateOnly? HiredDate { get; set; }

    public string? Position { get; set; }

    public int? Division { get; set; }

    public int? EmploymentStats { get; set; }

    public bool? CustomSched { get; set; }

    public int? Schedule { get; set; }

    public bool? AllowGraceperiod { get; set; }

    public DateOnly? SeparationDate { get; set; }

    public bool? MandatoryImmunity { get; set; }

    public bool? Fwa { get; set; }
}
