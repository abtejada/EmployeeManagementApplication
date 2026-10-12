using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsProvince
{
    public int IdProvince { get; set; }

    public string? ProvinceName { get; set; }

    public int? RegionId { get; set; }
}
