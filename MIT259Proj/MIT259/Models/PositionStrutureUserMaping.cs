using System;
using System.Collections.Generic;

namespace Eclipse360.Models;

public partial class PositionStrutureUserMaping
{
    public int Id { get; set; }

    public int StrutureId { get; set; }

    public int UserId { get; set; }
}
