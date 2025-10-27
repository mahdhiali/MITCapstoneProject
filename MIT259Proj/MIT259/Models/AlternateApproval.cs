using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class AlternateApproval
{
    public int Id { get; set; }

    public int ApprovalId { get; set; }

    public int RequestedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CompletedBy { get; set; }

    public DateTime ClosedDate { get; set; }

    public bool IsApprovalMandatory { get; set; }

    public int ApproverQueueId { get; set; }

    public virtual Approval Approval { get; set; } = null!;

    public virtual ApprovalTask RequestedByNavigation { get; set; } = null!;
}
