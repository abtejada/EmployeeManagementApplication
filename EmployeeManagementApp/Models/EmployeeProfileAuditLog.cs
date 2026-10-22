using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApp.Models
{
    [Table("EmployeeProfileAuditLogs")]
    public class EmployeeProfileAuditLog
    {
        [Key]
        [Column("AuditId")]
        public int AuditId { get; set; }

        [Column("HrisId")]
        public int HrisId { get; set; }

        [Column("EmployeeId")]
        public string EmployeeId { get; set; } = string.Empty;

        [Column("Description")]
        public string Description { get; set; } = string.Empty;

        [Column("ModifiedBy")]
        public string ModifiedBy { get; set; } = string.Empty;

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}