using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class InvPo
{
    public int Id { get; set; }

    public int InvId { get; set; }

    public string? AdditionalNote { get; set; }

    public DateTime RecordDateTime { get; set; }

    public int CreatedBy { get; set; }

    public int ApprovedBy { get; set; }

    public string ItemDetails { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public int PaymentMethod { get; set; }

    public virtual Invoice Inv { get; set; } = null!;

    public virtual PaymentMethod InvNavigation { get; set; } = null!;
}
