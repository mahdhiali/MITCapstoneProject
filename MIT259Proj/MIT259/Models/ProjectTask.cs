using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ProjectTask
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int CreatedBy { get; set; }

    public int? AssignedTo { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ScheduleStart { get; set; }

    public DateTime ScheduleEnd { get; set; }

    public DateTime? ActualStart { get; set; }

    public DateTime? ActualEnd { get; set; }

    public int TemplateId { get; set; }

    public string? AdditionalDesc { get; set; }

    public string? CrewTeam { get; set; }

    public int? ClosedBy { get; set; }

    public DateTime? ClosedDateTime { get; set; }

    public int Priority { get; set; }

    public int? ClosedStatus { get; set; }

    public int? OverDue { get; set; }

    public virtual AspNetUser? ClosedByNavigation { get; set; }

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;

    public virtual ICollection<UsedResourceForTask> UsedResourceForTasks { get; set; } = new List<UsedResourceForTask>();
}
