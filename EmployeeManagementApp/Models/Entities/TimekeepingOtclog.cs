using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingOtclog
{
    public int EntryNum { get; set; }

    public string PersonnelId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public byte Modtype { get; set; }

    public byte Action { get; set; }

    public DateTime Logtime { get; set; }

    public int Workcode { get; set; }

    public string DeviceSn { get; set; } = null!;

    public int Sched { get; set; }

    public int Flexi { get; set; }

    public bool NoMandosched { get; set; }
}
