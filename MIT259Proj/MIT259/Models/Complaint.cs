using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class Complaint
{
    public int Id { get; set; }

    public int Catergory { get; set; }

    public string RefrenceNo { get; set; } = null!;

    public int CusId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Status { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? Solution { get; set; }

    public int? CusSatification { get; set; }

    public virtual ComplaintTask CatergoryNavigation { get; set; } = null!;

    public virtual ICollection<CoplaintHistory> CoplaintHistories { get; set; } = new List<CoplaintHistory>();

    public virtual Customer Cus { get; set; } = null!;
}
