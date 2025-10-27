using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ProjectNodType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Desc { get; set; }
}
