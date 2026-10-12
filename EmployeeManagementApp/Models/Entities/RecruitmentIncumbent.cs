using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class RecruitmentIncumbent
{
    public int Id { get; set; }

    public int JobId { get; set; }

    public string Nature { get; set; } = null!;

    public int HrisId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateOnly? VacantDate { get; set; }

    public string? ReasonOfVacant { get; set; }
}
