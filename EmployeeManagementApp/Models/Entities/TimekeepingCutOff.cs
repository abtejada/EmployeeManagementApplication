using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingCutOff
{
    public DateOnly Cutoff { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedInfo { get; set; }
}
