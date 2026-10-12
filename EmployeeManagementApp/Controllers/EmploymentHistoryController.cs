using Microsoft.AspNetCore.Mvc;
using EmployeeManagementApp.Models;

namespace EmployeeManagementApp.Controllers
{
    public class EmploymentHistoryController : Controller
    {
        public IActionResult Index(string? searchTerm, string? eventTypeFilter)
        {
            var historyList = new List<EmploymentHistory>
            {
                new EmploymentHistory { Id = 101, EmployeeId = 1003, EmployeeName = "John Smith", EventType = "Separated", EventDate = new DateTime(2025, 12, 31), Department = "HR", Position = "Administrative Aide", Remarks = "Resigned to pursue higher studies." },
                new EmploymentHistory { Id = 100, EmployeeId = 1003, EmployeeName = "John Smith", EventType = "Hired", EventDate = new DateTime(2022, 01, 15), Department = "HR", Position = "Administrative Aide", Remarks = "Initial appointment." },
                new EmploymentHistory { Id = 99, EmployeeId = 1002, EmployeeName = "Jane Doe", EventType = "Hired", EventDate = new DateTime(2022, 06, 01), Department = "MID", Position = "Programmer II", Remarks = "Re-hired under new contract." },
                new EmploymentHistory { Id = 98, EmployeeId = 1001, EmployeeName = "Jane Doe", EventType = "Separated", EventDate = new DateTime(2022, 05, 30), Department = "MID", Position = "Junior Analyst", Remarks = "Resigned" },
                new EmploymentHistory { Id = 97, EmployeeId = 1001, EmployeeName = "Jane Doe", EventType = "Hired", EventDate = new DateTime(2021, 01, 10), Department = "MID", Position = "Junior Analyst", Remarks = "contract signed" }
            };

            // 1. Filter by keyword
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                historyList = historyList.Where(h =>
                    h.EmployeeName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    h.Remarks.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // 2. Filter by event type
            if (!string.IsNullOrWhiteSpace(eventTypeFilter) && eventTypeFilter != "All")
            {
                historyList = historyList.Where(h => h.EventType.Equals(eventTypeFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View(historyList);
        }
    }
}