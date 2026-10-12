using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsBarangay
{
    public int IdBrgy { get; set; }

    public string? BrgyName { get; set; }

    public int? IdCity { get; set; }
}
