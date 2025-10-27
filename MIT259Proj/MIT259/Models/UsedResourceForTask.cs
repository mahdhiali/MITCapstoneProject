using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class UsedResourceForTask
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string DateTime { get; set; } = null!;

    public int CreatedBy { get; set; }

    public string? Data { get; set; }

    public int ResourceType { get; set; }

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual ResourceType ResourceTypeNavigation { get; set; } = null!;

    public virtual ProjectTask Task { get; set; } = null!;
}
