using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelLogincredential
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? Password { get; set; }

    public string? UserType { get; set; }
}
