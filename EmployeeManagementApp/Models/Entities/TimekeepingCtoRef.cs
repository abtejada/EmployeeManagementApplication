using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingCtoRef
{
    public DateOnly? CtoFrom { get; set; }

    public DateOnly? CtoTo { get; set; }

    public int NumberHr { get; set; }

    public bool Montly { get; set; }
}
