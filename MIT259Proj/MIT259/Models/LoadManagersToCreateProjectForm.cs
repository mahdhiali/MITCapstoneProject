using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class LoadManagersToCreateProjectForm
{
    public int LoginId { get; set; }

    public string Fname { get; set; } = null!;

    public string? Mname { get; set; }

    public string? Lname { get; set; }
}
