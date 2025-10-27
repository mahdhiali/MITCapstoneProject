using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CoplaintHistory
{
    public int Id { get; set; }

    public int ComplientId { get; set; }

    public DateTime RecordDateTime { get; set; }

    public string? Description { get; set; }

    public int RecordBy { get; set; }

    public virtual Complaint Complient { get; set; } = null!;
}
