using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingDevice
{
    public int Id { get; set; }

    public string MachineName { get; set; } = null!;

    public string ConnectType { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public string? ProductName { get; set; }

    public int Port { get; set; }

    public string Commkey { get; set; } = null!;

    public bool Active { get; set; }

    public string? SerialNumber { get; set; }
}
