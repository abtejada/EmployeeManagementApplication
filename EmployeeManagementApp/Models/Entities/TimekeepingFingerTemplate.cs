using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingFingerTemplate
{
    public int BioId { get; set; }

    public byte Findex { get; set; }

    public string Template { get; set; } = null!;

    public byte Iflag { get; set; }
}
