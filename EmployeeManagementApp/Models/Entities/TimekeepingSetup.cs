using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingSetup
{
    public int Id { get; set; }

    public byte WorkingHrs { get; set; }

    public byte Workingmins { get; set; }

    public byte Graceperiod { get; set; }

    public bool GraceperiodEnable { get; set; }

    public bool DsSs { get; set; }

    public byte Selectedsched { get; set; }

    public string ImperativeSched { get; set; } = null!;

    public bool ImperativeEnable { get; set; }

    public byte SelectedImpSched { get; set; }
}
