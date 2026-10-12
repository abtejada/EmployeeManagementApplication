using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingLogin
{
    public int Id { get; set; }

    public string Usern { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public bool Reset { get; set; }

    public int HrisId { get; set; }

    public bool? IsLock { get; set; }
}
