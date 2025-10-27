using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class NotificationHistory
{
    public int Id { get; set; }

    public int SentBy { get; set; }

    public DateTime RecordDateTime { get; set; }

    public int UsedTemplatedId { get; set; }

    public string? AdditionalInfor { get; set; }
}
