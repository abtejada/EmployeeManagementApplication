using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class JobAppointOfficeHistory
{
    public int Id { get; set; }

    public int DivisionId { get; set; }

    public int? SectionId { get; set; }

    public int HrisId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateOnly AssumptionDate { get; set; }

    public string CreatedBy { get; set; } = null!;
}
