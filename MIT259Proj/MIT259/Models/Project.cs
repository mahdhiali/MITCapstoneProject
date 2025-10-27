using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Project
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProjectNode { get; set; }

    public int CatId { get; set; }

    public int Status { get; set; }

    public int ProjectManager { get; set; }

    public int? ProEng { get; set; }

    public int? SiteEng { get; set; }

    public string? ProjectTeam { get; set; }

    public string? ProjectLocationCoordination { get; set; }

    public string Quotation { get; set; } = null!;

    public DateOnly ExpectedStartDate { get; set; }

    public DateOnly? ClosedDate { get; set; }

    public int? ClosedBy { get; set; }

    public string? Attachments { get; set; }

    public virtual AspNetUser? ClosedByNavigation { get; set; }

    public virtual ProjectLocation ProjectNodeNavigation { get; set; } = null!;

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();
}
