using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingTempOfficialBusiness
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int ObRef { get; set; }

    public bool Deleted { get; set; }

    public string CreatedInfo { get; set; } = null!;

    public string? ModifiedInfo { get; set; }

    public string? Origin { get; set; }
}
