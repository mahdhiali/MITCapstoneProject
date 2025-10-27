using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Quotation
{
    public int Id { get; set; }

    public int CusId { get; set; }

    public int CreatedBy { get; set; }

    public string? RefranceNo { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? OpportunityId { get; set; }

    public int? AcceptedVerId { get; set; }

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual Customer Cus { get; set; } = null!;

    public virtual ICollection<QuoatVersion> QuoatVersions { get; set; } = new List<QuoatVersion>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
