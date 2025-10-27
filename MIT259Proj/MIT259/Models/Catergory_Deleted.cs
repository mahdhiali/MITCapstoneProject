using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Catergory_Deleted
{
    public int Id { get; set; }

    public int CatFor { get; set; }

    public string Name { get; set; } = null!;

    public virtual CatergoryFor_Deleted CatForNavigation { get; set; } = null!;
}
