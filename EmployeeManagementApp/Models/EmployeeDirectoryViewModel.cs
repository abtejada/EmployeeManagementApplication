namespace EmployeeManagementApp.Models
{
    public class EmployeeDirectoryViewModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public string EmployeeCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string DivisionShortName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        // New properties for Edit / Clear Separation features
        public string? SeparationDateFormatted { get; set; }
        public string? SeparationReason { get; set; }
        public bool HasExistingSeparation { get; set; }
    }
}