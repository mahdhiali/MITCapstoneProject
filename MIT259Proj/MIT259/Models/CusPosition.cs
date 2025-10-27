using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CusPosition
{
    public int Id { get; set; }

    public int CusId { get; set; }

    public int CompId { get; set; }

    public string? PositionName { get; set; }

    public int? CurrentStatus { get; set; }

    public virtual Company Comp { get; set; } = null!;

    public virtual Customer Cus { get; set; } = null!;
}
