using System;
using System.Collections.Generic;

namespace EmployeeManagementApp.Models.Entities;

public partial class PmsZipcode
{
    public int IdZipcode { get; set; }

    public int? Zipcode { get; set; }

    public int? IdBrgy { get; set; }
}
