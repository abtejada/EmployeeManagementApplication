using System;

namespace EmployeeManagementApp.Models
{
    public class DivisionAuditLogViewModel
    {
        public int AuditId { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
    }
}