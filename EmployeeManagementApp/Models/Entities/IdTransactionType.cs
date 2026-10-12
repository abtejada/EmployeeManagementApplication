using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdTransactionType
{
    public string? TransactionTypeId { get; set; }

    public string? TransactionName { get; set; }

    public string? Scope { get; set; }
}
