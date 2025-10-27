using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? FieldOfService { get; set; }

    public string? Address { get; set; }

    public string? WebSite { get; set; }

    public int? Phone { get; set; }

    public int? Phone1 { get; set; }

    public int? Lead { get; set; }

    public string? OfficialEmail { get; set; }

    public virtual ICollection<CusPosition> CusPositions { get; set; } = new List<CusPosition>();
}
