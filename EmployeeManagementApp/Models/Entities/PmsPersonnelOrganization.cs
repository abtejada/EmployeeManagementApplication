using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelOrganization
{
    public int MemberId { get; set; }

    public int HrisId { get; set; }

    public string? Organization { get; set; }

    public string? Position { get; set; }
}
