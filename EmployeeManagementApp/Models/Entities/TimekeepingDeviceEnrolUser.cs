using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingDeviceEnrolUser
{
    public int DeviceId { get; set; }

    public string? Name { get; set; }

    public int UserType { get; set; }

    public bool Active { get; set; }
}
