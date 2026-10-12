using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class ViewDeviceEnrolledDetail
{
    public int DeviceId { get; set; }

    public string? Name { get; set; }

    public string? Pass { get; set; }

    public string? Face { get; set; }

    public int? Finger { get; set; }

    public string UserType { get; set; } = null!;

    public bool Active { get; set; }
}
