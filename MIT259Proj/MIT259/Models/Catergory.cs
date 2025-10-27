using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Catergory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CatForId { get; set; }

    public string? Description { get; set; }

    public virtual CateregoryFor CatFor { get; set; } = null!;
}
