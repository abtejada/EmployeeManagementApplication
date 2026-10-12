using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingSignatory
{
    public int FormId { get; set; }

    public string FormName { get; set; } = null!;

    public string PreparedBy { get; set; } = null!;

    public string ReviewedBy { get; set; } = null!;

    public string CertifiedBy { get; set; } = null!;
}
