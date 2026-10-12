using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementApp.Models.Entities;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly PMMContext _context;

        // Inject PMMContext via Dependency Injection
        public EmployeeController(PMMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string? searchTerm, string? statusFilter, int? pageNumber)
        {
            int pageSize = 10;
            int pageIndex = pageNumber ?? 1;

            // 1. Query data sources from context
            var personnelQuery = _context.PmsPersonnelInformations.AsQueryable();
            var occupationQuery = _context.TimekeepingOccupationDetails.AsQueryable();

            // 2. Apply search filter if provided
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                personnelQuery = personnelQuery.Where(p =>
                    p.GivenName.Contains(searchTerm) ||
                    p.Surname.Contains(searchTerm) ||
                    p.HrisId.ToString().Contains(searchTerm));
            }

            var personnelList = await personnelQuery.ToListAsync();
            var occupationList = await occupationQuery.ToListAsync();

            // 3. Map to ViewModel and evaluate active/separated status based on SeparationDate
            var employeeDirectory = personnelList.Select(p => {
                var occ = occupationList.FirstOrDefault(o => o.HrisId.ToString().Trim() == p.HrisId.ToString().Trim());
                bool isActive = occ == null || occ.SeparationDate == null;

                return new EmployeeDirectoryViewModel
                {
                    EmployeeCode = p.HrisId.ToString(),
                    FullName = ((p.GivenName ?? "") + " " + (p.Surname ?? "")).Trim(),
                    Department = occ != null && occ.Division != null ? occ.Division.ToString() : "Unassigned",
                    Position = occ != null && occ.Position != null ? occ.Position.ToString() : "Unassigned",
                    IsActive = isActive
                };
            }).AsQueryable();

            // 4. Apply status filter from dropdown if provided
            if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
            {
                if (statusFilter == "Active")
                {
                    employeeDirectory = employeeDirectory.Where(e => e.IsActive);
                }
                else if (statusFilter == "Separated")
                {
                    employeeDirectory = employeeDirectory.Where(e => !e.IsActive);
                }
            }

            // 5. Pagination calculations
            int totalItems = employeeDirectory.Count();
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            if (totalPages > 0 && pageIndex > totalPages) pageIndex = totalPages;
            if (pageIndex < 1) pageIndex = 1;

            var paginatedList = employeeDirectory
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // 6. Assign sequential ID index per page
            int index = (pageIndex - 1) * pageSize + 1;
            foreach (var emp in paginatedList)
            {
                emp.Id = index++;
            }

            // 7. Pass filter and pagination state to the view
            ViewData["CurrentFilter"] = searchTerm;
            ViewData["CurrentStatus"] = statusFilter;
            ViewData["CurrentPage"] = pageIndex;
            ViewData["TotalPages"] = totalPages > 0 ? totalPages : 1;

            return View(paginatedList);
        }
        // ==========================================
        // AJAX ENDPOINT: Update Employee Separation
        // ==========================================
        [HttpPost]
        public async Task<IActionResult> UpdateSeparation(string employeeCode, DateTime? separationDate, string? separationReason)
        {
            try
            {
                if (int.TryParse(employeeCode, out int hrisId))
                {
                    var existingRecord = await _context.TimekeepingOccupationDetails
                        .FirstOrDefaultAsync(o => o.HrisId == hrisId);

                    if (existingRecord != null)
                    {
                        // Update existing record
                        string sql = "UPDATE timekeeping_OccupationDetails SET separation_date = {0} WHERE hris_id = {1}";
                        await _context.Database.ExecuteSqlRawAsync(sql, separationDate, hrisId);
                    }
                    else
                    {
                        // Insert new record if none exists yet
                        string sql = "INSERT INTO timekeeping_OccupationDetails (hris_id, separation_date) VALUES ({0}, {1})";
                        await _context.Database.ExecuteSqlRawAsync(sql, hrisId, separationDate);
                    }

                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Invalid Employee Code format." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        
    }

    public class EmployeeDirectoryViewModel
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string EmploymentType { get; set; } = string.Empty; // Added property
        public bool IsActive { get; set; } = true;
    }
}