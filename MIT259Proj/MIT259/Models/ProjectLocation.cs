using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ProjectLocation
{
    public int Id { get; set; }

    public string NodName { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int CatId { get; set; }

    public bool HaveChild { get; set; }

    public int? ParentId { get; set; }

    public int? Nodetype { get; set; }

    public int? ProjectType { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? ProjLocationLat { get; set; }

    public string? ProjLocationLong { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
