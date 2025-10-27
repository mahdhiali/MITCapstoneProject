using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ComplaintTaskHistory
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public int OpenedBy { get; set; }

    public int? UpdatedStatus { get; set; }

    public DateTime RecordDateTime { get; set; }

    public string? CommentNote { get; set; }

    public virtual ComplaintTask Task { get; set; } = null!;
}
