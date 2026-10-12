using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingTempCtoFiled
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public byte CtoHr { get; set; }

    public int? Implementation { get; set; }

    public string EmpId { get; set; } = null!;

    public bool Deleted { get; set; }

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }

    public string? Origin { get; set; }
}
