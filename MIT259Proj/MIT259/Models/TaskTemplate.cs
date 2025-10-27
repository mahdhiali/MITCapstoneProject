using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class TaskTemplate
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int Status { get; set; }

    public int PurposeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<ComplaintTask> ComplaintTasks { get; set; } = new List<ComplaintTask>();
}
