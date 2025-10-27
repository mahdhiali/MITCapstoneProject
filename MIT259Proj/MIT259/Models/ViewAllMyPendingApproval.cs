using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ViewAllMyPendingApproval
{
    public int? Id { get; set; }

    public int Expr1 { get; set; }

    public int ApprovalId { get; set; }

    public int QueueId { get; set; }

    public int? Status { get; set; }

    public string? ApplicationStatus { get; set; }

    public string? Subject { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? QuVerid { get; set; }

    public int? QuoatId { get; set; }

    public int? QvId { get; set; }

    public string? QvRefreNo { get; set; }
}
