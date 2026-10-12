using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPvaoPlantilla
{
    public string PlantillaId { get; set; } = null!;

    public string? PositionCode { get; set; }

    public int? HrisId { get; set; }

    public string? FullName { get; set; }

    public string? OrgLocDiv { get; set; }
}
