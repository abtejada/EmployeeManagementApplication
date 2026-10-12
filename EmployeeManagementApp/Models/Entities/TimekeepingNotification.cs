using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingNotification
{
    public int Id { get; set; }

    public string Information { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public bool Viewed { get; set; }
}
