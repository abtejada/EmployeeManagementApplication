namespace EmployeeManagementApp.Models
{
    public class EmployeeDirectoryViewModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public string EmployeeCode { get; set; } = string.Empty;

        // Name components
        public string? Prefix { get; set; }

        public string? Suffix { get; set; }
        public string GivenName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string? ExtensionName { get; set; }

        public string FullName => $"{Prefix ?? ""} {GivenName} {MiddleName ?? ""} {Surname} {ExtensionName ?? ""}".Trim().Replace("  ", " ");

        public string Department { get; set; } = string.Empty;
        public string DivisionShortName { get; set; } = string.Empty; // <--- Make sure this line exists!
        public string Position { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        // Separation & Remarks info
        public string? SeparationDateFormatted { get; set; }
        public string? SeparationReason { get; set; }
        public string? SeparationRemarks { get; set; }
        public bool HasExistingSeparation { get; set; }
    }
}