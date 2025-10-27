using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Lead
{
    public int Id { get; set; }

    public int Cat { get; set; }

    public string Name { get; set; } = null!;

    public virtual LeadCatergory CatNavigation { get; set; } = null!;
}
