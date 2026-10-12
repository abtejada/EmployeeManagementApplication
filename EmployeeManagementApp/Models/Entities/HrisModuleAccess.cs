using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class HrisModuleAccess
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public bool? Amm { get; set; }

    public bool? ObLo { get; set; }
}
