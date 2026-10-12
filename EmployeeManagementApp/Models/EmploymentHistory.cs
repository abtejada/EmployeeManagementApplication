namespace EmployeeManagementApp.Models
{
    public class EmploymentHistory
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty; // e.g., "Hired", "Re-hired", "Separated"
        public DateTime EventDate { get; set; }
        public string Position { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
    }
}