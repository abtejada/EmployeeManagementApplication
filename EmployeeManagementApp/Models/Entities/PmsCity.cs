using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsCity
{
    public int IdCity { get; set; }

    public string? CityName { get; set; }

    public int? ProvinceId { get; set; }
}
