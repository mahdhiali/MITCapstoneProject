using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApproverQueMember
{
    public int Id { get; set; }

    public int QueueId { get; set; }

    public int UserId { get; set; }

    public virtual ApproverQueue Queue { get; set; } = null!;
}
