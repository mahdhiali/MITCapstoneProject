using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApprovalDoA
{
    public int Id { get; set; }

    public string DoAname { get; set; } = null!;

    public int Type { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool ActiveStatus { get; set; }

    public int ApprovalFor { get; set; }

    public string? FlowData { get; set; }

    public int? DefaultVersion { get; set; }

    public virtual ICollection<ApprovalDoAflowVersion> ApprovalDoAflowVersions { get; set; } = new List<ApprovalDoAflowVersion>();

    public virtual ApprovalDoAfor ApprovalForNavigation { get; set; } = null!;

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual ApprovalDoatype TypeNavigation { get; set; } = null!;
}
