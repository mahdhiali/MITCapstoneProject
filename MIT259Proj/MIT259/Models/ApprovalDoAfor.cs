using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApprovalDoAfor
{
    public int Id { get; set; }

    public string Purpose { get; set; } = null!;

    public virtual ICollection<ApprovalDoA> ApprovalDoAs { get; set; } = new List<ApprovalDoA>();
}
