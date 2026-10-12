using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class TimekeepingEvaluation
{
    public int Id { get; set; }

    public int HrisId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public int TardNum { get; set; }

    public int UnderNum { get; set; }

    public int AbsentNum { get; set; }

    public int TardHrtotal { get; set; }

    public int TardMntotal { get; set; }

    public int UnderHrtotal { get; set; }

    public int UnderMntotal { get; set; }
}
