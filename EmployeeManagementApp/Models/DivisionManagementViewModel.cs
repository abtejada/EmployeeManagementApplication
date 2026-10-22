using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagementApp.Models
{
    public class DivisionManagementViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sname { get; set; } = string.Empty;

        // Status is bit -> bool? in C#
        public bool? Status { get; set; }

        public int? DivIdSuperior { get; set; }

        public int? HeadHrisId { get; set; }
        public string HeadName { get; set; } = string.Empty;

        public string Designation { get; set; } = string.Empty;
        public int? AlternateHead { get; set; }

        public string AlternateHeadDesignation { get; set; } = string.Empty;
        public string AlternateHeadName { get; set; } = string.Empty;

        // Office Level is int -> int? in C#
        public int? OfficeLevel { get; set; }

        public IEnumerable<SelectListItem> PersonnelOptions { get; set; } = new List<SelectListItem>();
    }
}