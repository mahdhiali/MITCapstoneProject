using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class StatusFor
{
    public int Id { get; set; }

    public string ModulePurpose { get; set; } = null!;

    public virtual ICollection<Status> Statuses { get; set; } = new List<Status>();
}
