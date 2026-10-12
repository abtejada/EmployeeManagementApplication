using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class FinalList
{
    public double? HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public DateTime? HiredDate { get; set; }

    public string? Position { get; set; }

    public string? Sname { get; set; }
}
