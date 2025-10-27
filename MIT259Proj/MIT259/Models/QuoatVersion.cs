using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class QuoatVersion
{
    public int Id { get; set; }

    public int QuoatId { get; set; }

    public int RevAtt { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public decimal GrantTotal { get; set; }

    public decimal Dscount { get; set; }

    public decimal NetTotal { get; set; }

    public string? RefreNo { get; set; }

    public string? FormData { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public int? Status { get; set; }

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual Quotation Quoat { get; set; } = null!;

    public virtual ICollection<QuoatDatum> QuoatData { get; set; } = new List<QuoatDatum>();
}
