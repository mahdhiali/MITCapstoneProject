using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class AspNetUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<ApprovalDoA> ApprovalDoAs { get; set; } = new List<ApprovalDoA>();

    public virtual ICollection<ApprovalTask> ApprovalTasks { get; set; } = new List<ApprovalTask>();

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual ICollection<ApproverQueue> ApproverQueues { get; set; } = new List<ApproverQueue>();

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<CusOpportunity> CusOpportunities { get; set; } = new List<CusOpportunity>();

    public virtual ICollection<ProjectLocation> ProjectLocations { get; set; } = new List<ProjectLocation>();

    public virtual ICollection<ProjectTask> ProjectTaskClosedByNavigations { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> ProjectTaskCreatedByNavigations { get; set; } = new List<ProjectTask>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<QuoatVersion> QuoatVersions { get; set; } = new List<QuoatVersion>();

    public virtual ICollection<Quotation> Quotations { get; set; } = new List<Quotation>();

    public virtual ICollection<UsedResourceForTask> UsedResourceForTasks { get; set; } = new List<UsedResourceForTask>();
}
