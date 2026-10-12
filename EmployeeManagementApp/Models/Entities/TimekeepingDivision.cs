using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingDivision
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Sname { get; set; }

    public bool? Status { get; set; }

    public int? DivIdSuperior { get; set; }

    public int? HeadHrisId { get; set; }

    public string? Designation { get; set; }

    public int? AlternateHead { get; set; }

    public string? AlternateHeadDesignation { get; set; }

    public int? OfficeLevel { get; set; }
}
