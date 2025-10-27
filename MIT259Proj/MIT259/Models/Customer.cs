using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string? Mname { get; set; }

    public string Lname { get; set; } = null!;

    public string? Gender { get; set; }

    public int? Nationality { get; set; }

    public string? Address { get; set; }

    public string? StateProvince { get; set; }

    public string? City { get; set; }

    public int? Country { get; set; }

    public string? PostalCode { get; set; }

    public int? Phone { get; set; }

    public int Mobile1 { get; set; }

    public int? Mobile2 { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Nicno { get; set; }

    public string? PassportNo { get; set; }

    public int CurrentStatus { get; set; }

    public int Lead { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CustomerRating { get; set; }

    public int? Status { get; set; }

    public string? Intrest { get; set; }

    public virtual ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();

    public virtual ICollection<CusPosition> CusPositions { get; set; } = new List<CusPosition>();

    public virtual ICollection<Quotation> Quotations { get; set; } = new List<Quotation>();
}
