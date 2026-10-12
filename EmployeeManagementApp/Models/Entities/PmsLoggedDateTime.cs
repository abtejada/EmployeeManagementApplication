using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsLoggedDateTime
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public DateTime? LoggedDateTime { get; set; }

    public string? IpAddress { get; set; }
}
