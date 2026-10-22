using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApp.Models
{
    [Table("DivisionAuditLogs")]
    public class DivisionAuditLog
    {
        [Key]
        [Column("AuditId")]
        public int AuditId { get; set; }

        [Column("DivisionId")]
        public int DivisionId { get; set; }

        [Column("DivisionName")]
        public string DivisionName { get; set; } = string.Empty;

        [Column("Description")]
        public string Description { get; set; } = string.Empty;

        [Column("ModifiedBy")]
        public string ModifiedBy { get; set; } = string.Empty;

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}