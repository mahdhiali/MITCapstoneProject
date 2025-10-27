using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class CountryList
{
    public int Id { get; set; }

    public string Enname { get; set; } = null!;

    public string Arname { get; set; } = null!;

    public string TelCode { get; set; } = null!;

    public string? CurrencySymbole { get; set; }
}
