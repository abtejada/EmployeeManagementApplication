using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApp.Models
{
    [Table("EmployeeSeparationHistories")]
    public class EmployeeSeparationHistory
    {
        [Key]
        [Column("HistoryId")]
        public int SeparationLogId { get; set; }

        [Column("hris_id")]
        public int HrisId { get; set; }

        [Column("SeparationDate")]
        public DateOnly? SeparationDate { get; set; }

        [Column("SeparationReason")]
        public string? SeparationReason { get; set; }

        [Column("SeparationRemarks")]
        public string? SeparationRemarks { get; set; }

        [Column("SeparatedBy")]
        public string? SeparatedBy { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}