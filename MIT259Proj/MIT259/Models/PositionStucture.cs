using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class PositionStucture
{
    public int Id { get; set; }

    public string StrutureTitle { get; set; } = null!;

    public string? Description { get; set; }
}
