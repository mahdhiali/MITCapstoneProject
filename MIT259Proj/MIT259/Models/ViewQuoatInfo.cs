using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ViewQuoatInfo
{
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? QuotationStatus { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? CustomerStatus { get; set; }

    public int? Mobile1 { get; set; }

    public string? Enname { get; set; }

    public string? Country { get; set; }

    public string? LeadSource { get; set; }

    public string? UserFirstName { get; set; }

    public string? UserLname { get; set; }
}
