using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdTransactionAudit
{
    public string TransactionAuditId { get; set; } = null!;

    public string? IdNo { get; set; }

    public string? TransactionTypeCode { get; set; }

    public string? TransactionName { get; set; }

    public string? Remarks { get; set; }

    public DateTime? ExecutedDate { get; set; }

    public string? ExecutedUserId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? ReferenceCode { get; set; }
}
