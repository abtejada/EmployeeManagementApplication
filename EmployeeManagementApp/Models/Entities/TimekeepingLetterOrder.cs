using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingLetterOrder
{
    public int Id { get; set; }

    public string RefNo { get; set; } = null!;

    public string? Attachment { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public bool IsAmend { get; set; }

    public int? AmendedId { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<TimekeepingLetterOrderSub> TimekeepingLetterOrderSubs { get; set; } = new List<TimekeepingLetterOrderSub>();
}
