using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelSkill
{
    public int SkillId { get; set; }

    public int HrisId { get; set; }

    public string? Skill { get; set; }
}
