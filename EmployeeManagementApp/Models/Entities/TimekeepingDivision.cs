using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApp.Models.Entities
{
    [Table("timekeeping_Division")]
    public partial class TimekeepingDivision
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("sname")]
        public string? Sname { get; set; }

        [Column("status")]
        public bool? Status { get; set; }

        [Column("div_id_superior")]
        public int? DivIdSuperior { get; set; }

        [Column("head_hris_id")]
        public int? HeadHrisId { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("alternate_head")]
        public int? AlternateHead { get; set; }

        [Column("alternate_head_designation")]
        public string? AlternateHeadDesignation { get; set; }

        [Column("office_level")]
        public int? OfficeLevel { get; set; }
    }
}