using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApprovalTask
{
    public int Id { get; set; }

    public int ApprovalId { get; set; }

    public int? ApprovalPositionId { get; set; }

    public int? ParentTaskId { get; set; }

    public bool TaskStatus { get; set; }

    public DateTime CreatedDate { get; set; }

    public int AssignedTo { get; set; }

    public int? PeformedAction { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int? CompletedBy { get; set; }

    public string? Comment { get; set; }

    public string? Attachment { get; set; }

    public int DoAflowId { get; set; }

    public virtual ICollection<AlternateApproval> AlternateApprovals { get; set; } = new List<AlternateApproval>();

    public virtual Approval Approval { get; set; } = null!;

    public virtual AspNetUser? CompletedByNavigation { get; set; }

    public virtual ApprovalDoAflowVersion DoAflow { get; set; } = null!;
}
