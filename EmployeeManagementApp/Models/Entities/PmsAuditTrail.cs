using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsAuditTrail
{
    public int Id { get; set; }

    public string? Details { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateTime { get; set; }
}
