using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Sale
{
    public int Id { get; set; }

    public int QuotId { get; set; }

    public int PaymentMethodId { get; set; }

    public string? Agrement { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public int Catergory { get; set; }

    public int? InvId { get; set; }

    public virtual Invoice? Inv { get; set; }

    public virtual Quotation Quot { get; set; } = null!;
}
