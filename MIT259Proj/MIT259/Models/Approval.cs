using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Approval
{
    public int Id { get; set; }

    public string ApplicationFor { get; set; } = null!;

    public int DocumentId { get; set; }

    public int DoAid { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Status { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? AlternateApprovals { get; set; }

    public string? ApprovalCollection { get; set; }

    public int? ApprovedActionCount { get; set; }

    public virtual ICollection<AlternateApproval> AlternateApprovalsNavigation { get; set; } = new List<AlternateApproval>();

    public virtual ICollection<ApprovalTask> ApprovalTasks { get; set; } = new List<ApprovalTask>();

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual ApprovalDoA DoA { get; set; } = null!;
}
