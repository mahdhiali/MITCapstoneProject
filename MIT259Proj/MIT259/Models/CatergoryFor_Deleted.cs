using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CatergoryFor_Deleted
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Catergory_Deleted> Catergories { get; set; } = new List<Catergory_Deleted>();
}
