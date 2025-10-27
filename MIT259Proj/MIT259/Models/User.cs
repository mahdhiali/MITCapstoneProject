using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class User
{
    public int Id { get; set; }

    public string? AsptableId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string EmpId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<Approval> Approvals { get; set; } = new List<Approval>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Quotation> Quotations { get; set; } = new List<Quotation>();
}
