using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class Awardee
{
    public int HrisId { get; set; }

    public string? EmployeeId { get; set; }

    public string NameOfEmployee { get; set; } = null!;

    public string? Position { get; set; }

    public DateOnly? HiredDate { get; set; }

    public string? Name { get; set; }

    public string? MonthName { get; set; }

    public string? Remarks { get; set; }
}
