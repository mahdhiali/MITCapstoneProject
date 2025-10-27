using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class LeadCatergory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Lead> Leads { get; set; } = new List<Lead>();
}
