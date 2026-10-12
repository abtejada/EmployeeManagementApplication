using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TownHallMf
{
    public int HrisId { get; set; }

    public string NameEmployee { get; set; } = null!;

    public DateOnly? BirthDate { get; set; }

    public string? Name { get; set; }
}
