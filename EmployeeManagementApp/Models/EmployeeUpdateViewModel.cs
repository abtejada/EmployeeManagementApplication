using System;

namespace EmployeeManagementApp.Models
{
    public class EmployeeUpdateViewModel
    {
        public string EmployeeCode { get; set; } = string.Empty; // hris_id

        // Profile fields
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public string GivenName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string? ExtensionName { get; set; }

        // Separation fields
        public DateOnly? SeparationDate { get; set; }
        public string? SeparationReason { get; set; }
        public string? SeparationRemarks { get; set; }
    }
}