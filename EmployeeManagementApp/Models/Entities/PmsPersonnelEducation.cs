using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelEducation
{
    public int EducId { get; set; }

    public int HrisId { get; set; }

    public string? EducationalLevel { get; set; }

    public string? SchoolName { get; set; }

    public string? CourseName { get; set; }

    public int? AttendedFrom { get; set; }

    public int? AttendedTo { get; set; }

    public string? HighestLevel { get; set; }

    public int? YearGraduated { get; set; }

    public string? ScholarshipHonors { get; set; }
}
