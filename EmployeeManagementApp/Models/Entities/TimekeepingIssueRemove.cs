using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingIssueRemove
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int EmpId { get; set; }

    public bool IsDelete { get; set; }

    public string CreatedInfo { get; set; } = null!;
}
