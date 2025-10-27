using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class UserInfro
{
    public int Id { get; set; }

    public string EmpId { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string? Mname { get; set; }

    public string? Lname { get; set; }

    public DateOnly RegistredDate { get; set; }

    public bool Active { get; set; }

    public int LoginId { get; set; }

    public DateOnly? DisabledDate { get; set; }

    public int CreatedBy { get; set; }

    public string? CompEmail { get; set; }

    public string? PrimaryMobileNumber { get; set; }

    public string? SecondaryMobile { get; set; }

    public string? Whatsapp { get; set; }

    public string Gender { get; set; } = null!;

    public int PrimaryNationality { get; set; }
}
