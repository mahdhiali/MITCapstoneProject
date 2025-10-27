using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ViewQoVerDt
{
    public int Id { get; set; }

    public int QuoatId { get; set; }

    public string? RefreNo { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal Dscount { get; set; }

    public string? FormData { get; set; }

    public decimal GrantTotal { get; set; }

    public decimal NetTotal { get; set; }

    public int RevAtt { get; set; }

    public string? Qvstatus { get; set; }
}
