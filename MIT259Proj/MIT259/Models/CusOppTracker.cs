using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CusOppTracker
{
    public int Id { get; set; }

    public int CusOppId { get; set; }

    public int Owner { get; set; }

    public string? Note { get; set; }

    public int? SuccessRate { get; set; }

    public DateTime RecordDate { get; set; }

    public string? MeetingHour { get; set; }

    public string? Crew { get; set; }

    public virtual CusOpportunity CusOpp { get; set; } = null!;
}
