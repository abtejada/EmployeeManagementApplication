using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingJointId
{
    public int? BiometricId { get; set; }

    public string? EmpId { get; set; }
}
