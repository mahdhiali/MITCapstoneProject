using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApprovalDoAflowVersion
{
    public int Id { get; set; }

    public int DoAid { get; set; }

    public int VersionNo { get; set; }

    public virtual ICollection<ApprovalDoAflow> ApprovalDoAflows { get; set; } = new List<ApprovalDoAflow>();

    public virtual ICollection<ApprovalTask> ApprovalTasks { get; set; } = new List<ApprovalTask>();

    public virtual ApprovalDoA DoA { get; set; } = null!;
}
