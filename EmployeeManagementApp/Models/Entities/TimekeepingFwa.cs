using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingFwa
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public string Mon { get; set; } = null!;

    public string Tue { get; set; } = null!;

    public string Wed { get; set; } = null!;

    public string Thu { get; set; } = null!;

    public string Fri { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public string? LastModifyInfo { get; set; }
}
