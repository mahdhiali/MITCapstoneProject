using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApprovalDoatype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ApprovalDoA> ApprovalDoAs { get; set; } = new List<ApprovalDoA>();
}
