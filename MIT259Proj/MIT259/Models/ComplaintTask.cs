using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ComplaintTask
{
    public int Id { get; set; }

    public int CompId { get; set; }

    public int TaskCreatedBy { get; set; }

    public int TaskOwner { get; set; }

    public int Status { get; set; }

    public int TaskTemplateId { get; set; }

    public string? AdditioanlDescRiption { get; set; }

    public string? ClosureNote { get; set; }

    public DateTime? ClosedDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<ComplaintTaskHistory> ComplaintTaskHistories { get; set; } = new List<ComplaintTaskHistory>();

    public virtual ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();

    public virtual TaskTemplate TaskTemplate { get; set; } = null!;
}
