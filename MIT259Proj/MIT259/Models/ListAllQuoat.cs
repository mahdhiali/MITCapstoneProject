using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class ListAllQuoat
{
    public int? VerRowId { get; set; }

    public int Id { get; set; }

    public string? RefreNo { get; set; }

    public int? RevAtt { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? NetTotal { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Name { get; set; }
}
