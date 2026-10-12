using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelParent
{
    public int? HrisId { get; set; }

    public string? FatherSurname { get; set; }

    public string? FatherGivenName { get; set; }

    public string? FatherMiddleName { get; set; }

    public string? FatherExtensionName { get; set; }

    public string? MotherSurname { get; set; }

    public string? MotherGivenName { get; set; }

    public string? MotherMiddleName { get; set; }
}
