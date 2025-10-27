using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CusOpportunity
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public int OpportunityId { get; set; }

    public string? Ref { get; set; }

    public string? Note { get; set; }

    public int CreatedBy { get; set; }

    public string? AssignedTo { get; set; }

    public int? ProjectNo { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateOnly? ClosedDate { get; set; }

    public int CusId { get; set; }

    public virtual AspNetUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<CusOppTracker> CusOppTrackers { get; set; } = new List<CusOppTracker>();

    public virtual Opportunity Opportunity { get; set; } = null!;
}
