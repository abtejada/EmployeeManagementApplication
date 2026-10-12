using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class HrisLogincredential
{
    public int Id { get; set; }

    public string? HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Password { get; set; }

    public bool? Amm { get; set; }

    public bool? PmmEmp { get; set; }

    public bool? PmmAdmin { get; set; }

    public string? Status { get; set; }
}
