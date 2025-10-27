using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public string InvRef { get; set; } = null!;

    public int FroSaleProj { get; set; }

    public int CreatedBy { get; set; }

    public decimal TotalAmount { get; set; }

    public int Status { get; set; }

    public int ApprovedBy { get; set; }

    public virtual ICollection<InvPo> InvPos { get; set; } = new List<InvPo>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
