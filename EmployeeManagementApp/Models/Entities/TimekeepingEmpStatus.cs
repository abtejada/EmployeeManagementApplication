using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingEmpStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
