using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingForVeriOb
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public DateOnly Date { get; set; }

    public string Ref { get; set; } = null!;

    public int ObType { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }
}
