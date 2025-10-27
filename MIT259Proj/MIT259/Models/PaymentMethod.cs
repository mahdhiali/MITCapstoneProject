using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Desc { get; set; }

    public virtual ICollection<InvPo> InvPos { get; set; } = new List<InvPo>();
}
