using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class StatusFor_Deleted
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Status_Deleted> Statuses { get; set; } = new List<Status_Deleted>();
}
