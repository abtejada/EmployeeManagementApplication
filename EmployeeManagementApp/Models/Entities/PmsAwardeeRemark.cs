using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsAwardeeRemark
{
    public int Id { get; set; }

    public int? HrisId { get; set; }

    public string? Remarks { get; set; }
}
