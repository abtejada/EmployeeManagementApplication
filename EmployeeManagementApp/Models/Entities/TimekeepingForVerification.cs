using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingForVerification
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public DateOnly Date { get; set; }

    public string? Remarks { get; set; }

    public bool Done { get; set; }

    public DateTime DateGenerated { get; set; }
}
