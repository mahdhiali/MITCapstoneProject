using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ResourceType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<UsedResourceForTask> UsedResourceForTasks { get; set; } = new List<UsedResourceForTask>();
}
