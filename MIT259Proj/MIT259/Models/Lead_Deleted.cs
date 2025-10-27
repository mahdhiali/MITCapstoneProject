using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Lead_Deleted
{
    public int Id { get; set; }

    public int Cat { get; set; }

    public string Name { get; set; } = null!;

    public virtual LeadCatergory_Deleted CatNavigation { get; set; } = null!;
}
