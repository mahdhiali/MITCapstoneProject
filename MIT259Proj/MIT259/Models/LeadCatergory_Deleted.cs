using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class LeadCatergory_Deleted
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lead_Deleted> Leads { get; set; } = new List<Lead_Deleted>();
}
