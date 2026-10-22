using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApp.Models.Entities
{
    [Table("timekeeping_OccupationDetails")]
    public partial class TimekeepingOccupationDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("hris_id")]
        public int HrisId { get; set; }

        [Column("hired_date")]
        public DateOnly? HiredDate { get; set; }

        [Column("position")]
        public string? Position { get; set; }

        [Column("division")]
        public int? Division { get; set; }

        [Column("employment_stats")]
        public int? EmploymentStats { get; set; }

        [Column("custom_sched")]
        public bool? CustomSched { get; set; }

        [Column("schedule")]
        public int? Schedule { get; set; }

        [Column("allow_graceperiod")]
        public bool? AllowGraceperiod { get; set; }

        [Column("separation_date")]
        public DateTime? SeparationDate { get; set; }

        [Column("separation_reason")]
        public string? SeparationReason { get; set; }

        // Added SeparationRemarks property
        [Column("separation_remarks")]
        public string? SeparationRemarks { get; set; }

        [Column("mandatory_immunity")]
        public bool? MandatoryImmunity { get; set; }

        [Column("FWA")]
        public bool? Fwa { get; set; }

        [Column("section")]
        public int? Section { get; set; }
    }
}