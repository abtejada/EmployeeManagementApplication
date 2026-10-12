using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelRecognition
{
    public int RecogId { get; set; }

    public int HrisId { get; set; }

    public string? Organization { get; set; }

    public string? Recognition { get; set; }

    public DateOnly? AcquiredDate { get; set; }
}
