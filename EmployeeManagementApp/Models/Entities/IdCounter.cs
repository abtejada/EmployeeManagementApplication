using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdCounter
{
    public string KeyPrefix { get; set; } = null!;

    public int Counter { get; set; }

    public string? Description { get; set; }
}
