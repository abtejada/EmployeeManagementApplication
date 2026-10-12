using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsPersonnelInterview
{
    public int InterviewId { get; set; }

    public int HrisId { get; set; }

    public bool? ThirdDegree { get; set; }

    public bool? FourthDegree { get; set; }

    public string? DegreeDetails { get; set; }

    public bool? AdministrativeOffense { get; set; }

    public string? AoDetails { get; set; }

    public bool? CriminallyCharge { get; set; }

    public DateOnly? DateFiled { get; set; }

    public string? StatusCase { get; set; }

    public bool? Convicted { get; set; }

    public string? ConvictedDetails { get; set; }

    public bool? SeparatedService { get; set; }

    public string? SeparatedDetails { get; set; }

    public bool? ElectionCandidate { get; set; }

    public string? EcDetails { get; set; }

    public bool? ElectionResignation { get; set; }

    public string? ErDetails { get; set; }

    public bool? Immigrant { get; set; }

    public string? ImmigrantDetails { get; set; }

    public bool? IndigenousPerson { get; set; }

    public string? IpDetails { get; set; }

    public bool? Pwd { get; set; }

    public string? PwdDetails { get; set; }

    public string? PwdIdno { get; set; }

    public bool? SoloParent { get; set; }

    public string? SpDetails { get; set; }

    public bool? SpouseDescendant { get; set; }

    public string? SpdDetails { get; set; }

    public bool? PvaoScholar { get; set; }
}
