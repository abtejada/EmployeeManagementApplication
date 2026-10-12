using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingOccupationDetail
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public DateOnly? HiredDate { get; set; }

    public string? Position { get; set; }

    public int? Division { get; set; }

    public int? EmploymentStats { get; set; }

    public bool? CustomSched { get; set; }

    public int? Schedule { get; set; }

    public bool? AllowGraceperiod { get; set; }

    [Column("separation_date")]
    public DateTime? SeparationDate { get; set; }

    public bool? MandatoryImmunity { get; set; }

    public bool? Fwa { get; set; }

    public int? Section { get; set; }
}
