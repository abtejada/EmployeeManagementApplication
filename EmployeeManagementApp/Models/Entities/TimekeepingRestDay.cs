using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingRestDay
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public DateOnly Date { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
