using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelRelative
{
    public int Relativeid { get; set; }

    public int EmpHrisId { get; set; }

    public int RelativeHrisId { get; set; }

    public string? Fullname { get; set; }

    public string? Relationship { get; set; }
}
