using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Opportunity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Desc { get; set; }

    public virtual ICollection<CusOpportunity> CusOpportunities { get; set; } = new List<CusOpportunity>();
}
