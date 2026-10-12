using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class IdPersonnelId
{
    public string IdNo { get; set; } = null!;

    public string? PersonnelId { get; set; }

    public byte[]? IdImage { get; set; }

    public byte[]? SignatureImage { get; set; }

    public byte[]? Rthumb { get; set; }

    public byte[]? Lthumb { get; set; }

    public string? IdentifyingMark { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedUserId { get; set; }

    public byte[]? IdFingerPrint { get; set; }

    public string? IdFingerName { get; set; }
}
