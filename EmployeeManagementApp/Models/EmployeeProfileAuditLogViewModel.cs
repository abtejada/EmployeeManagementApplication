using System;

namespace EmployeeManagementApp.Models
{
    public class EmployeeProfileAuditLogViewModel
    {
        public int AuditId { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
    }
}