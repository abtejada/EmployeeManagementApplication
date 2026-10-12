using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelChild
{
    public int ChildId { get; set; }

    public int HrisId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? ExtensionName { get; set; }

    public DateOnly? BirthDate { get; set; }
}
