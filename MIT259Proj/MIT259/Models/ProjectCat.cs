using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ProjectCat
{
    public int Id { get; set; }

    public string CatName { get; set; } = null!;

    public int MyParentCatId { get; set; }
}
