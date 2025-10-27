using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class QuoatDatum
{
    public int Id { get; set; }

    public int QuVeId { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? Col3 { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Qty { get; set; }

    public string? UnitScal { get; set; }

    public virtual QuoatVersion QuVe { get; set; } = null!;
}
