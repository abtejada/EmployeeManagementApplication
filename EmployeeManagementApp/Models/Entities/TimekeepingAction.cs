using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingAction
{
    public int ActionId { get; set; }

    public string ActionName { get; set; } = null!;
}
