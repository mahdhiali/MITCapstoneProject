using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApprovalDoAflow
{
    public int Id { get; set; }

    public int? FlowId { get; set; }

    public int FlowVid { get; set; }

    public string? PositionTitle { get; set; }

    public int? PositionId { get; set; }

    public int? AssignedQue { get; set; }

    public int? MyParentPositionId { get; set; }

    public bool HaveChildPositions { get; set; }

    public bool MyApprovalIsMandatory { get; set; }

    public int? SlainHr { get; set; }

    public bool IamDefaultInTheFlow { get; set; }

    public bool Approve { get; set; }

    public bool Reject { get; set; }

    public bool ReturnForCorrection { get; set; }

    public bool ReturnToPreviousLevel { get; set; }

    public bool ApproveWithNotApplicable { get; set; }

    public string? IncludeAlternateApprovers { get; set; }

    public virtual ApprovalDoAflowVersion FlowV { get; set; } = null!;
}
