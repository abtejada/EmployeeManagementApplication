using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdPrintEntry
{
    public string PrintEntryId { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public string? HrisId { get; set; }

    public string? IdTemplate { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? PrintTypeId { get; set; }

    public string? PrintTypeName { get; set; }

    public string? PrintSourceId { get; set; }

    public DateOnly? IssuedDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public DateTime? QueuedDate { get; set; }

    public DateTime? LastAttemptedDate { get; set; }

    public string? Printer { get; set; }

    public DateTime? PrintedDate { get; set; }

    public int? Attempts { get; set; }

    public string? PrintStatus { get; set; }

    public string? PrintedBy { get; set; }

    public string? Remarks { get; set; }

    public int? Priority { get; set; }

    public string? Error { get; set; }

    public DateTime? RequeuedDate { get; set; }

    public DateTime? CancelledDate { get; set; }

    public DateTime? FailedDate { get; set; }
}
