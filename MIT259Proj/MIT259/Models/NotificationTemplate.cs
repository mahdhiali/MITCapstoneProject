using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class NotificationTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Body { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int Status { get; set; }
}
