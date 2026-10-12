using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PersonnelView
{
    public int HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public string? ExtensionName { get; set; }

    public string? Sname { get; set; }
}
