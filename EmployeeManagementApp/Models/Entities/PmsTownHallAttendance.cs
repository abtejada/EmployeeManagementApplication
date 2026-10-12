using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsTownHallAttendance
{
    public int Id { get; set; }

    public string? GrpId { get; set; }

    public string? Employee { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Division { get; set; }

    public string? FileName { get; set; }

    public string? Filepath { get; set; }

    public string? Createdby { get; set; }
}
