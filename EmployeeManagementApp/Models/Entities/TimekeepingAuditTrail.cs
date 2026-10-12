using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingAuditTrail
{
    public int Id { get; set; }

    public string Details { get; set; } = null!;

    public int ModifiedBy { get; set; }

    public DateTime DateTime { get; set; }
}
