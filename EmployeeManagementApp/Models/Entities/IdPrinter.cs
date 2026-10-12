using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdPrinter
{
    public string Serial { get; set; } = null!;

    public string? Model { get; set; }

    public string? Description { get; set; }
}
