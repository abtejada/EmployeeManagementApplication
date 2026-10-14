namespace EmployeeManagementApp.Models
{
    public class EmployeeSeparationHistoryViewModel
    {
        public int SeparationLogId { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public string EmployeeCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateOnly? SeparationDate { get; set; }
        public string? SeparationReason { get; set; }
        public string SeparatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}