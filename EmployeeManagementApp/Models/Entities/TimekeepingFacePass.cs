using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingFacePass
{
    public int BioId { get; set; }

    public string? Pass { get; set; }

    public string? Face { get; set; }

    public int? Ifacelenght { get; set; }
}
