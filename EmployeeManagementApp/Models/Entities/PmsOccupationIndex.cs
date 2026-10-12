using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsOccupationIndex
{
    public string? PositionCode { get; set; }

    public string? GroupCode { get; set; }

    public string? ServiceCode { get; set; }

    public string? Position { get; set; }

    public int? SalaryGrade { get; set; }
}
