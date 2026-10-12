using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingBioDeviceIdchecker
{
    public DateOnly CheckDate { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedInfo { get; set; }
}
