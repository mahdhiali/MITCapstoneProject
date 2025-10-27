using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CateregoryFor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Catergory> Catergories { get; set; } = new List<Catergory>();
}
