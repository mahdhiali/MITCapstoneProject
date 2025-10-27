using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Status
{
    public int Id { get; set; }

    public int StatusForId { get; set; }

    public string Name { get; set; } = null!;

    public virtual StatusFor StatusFor { get; set; } = null!;
}
