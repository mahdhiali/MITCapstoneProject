using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ApproverQueue
{
    public int Id { get; set; }

    public string QueName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool ActiveStatus { get; set; }

    public int CreatedBy { get; set; }

    public virtual ICollection<ApproverQueMember> ApproverQueMembers { get; set; } = new List<ApproverQueMember>();

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;
}
