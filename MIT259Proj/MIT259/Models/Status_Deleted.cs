using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Status_Deleted
{
    public int Id { get; set; }

    public int StatusFor { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual StatusFor_Deleted StatusForNavigation { get; set; } = null!;
}
