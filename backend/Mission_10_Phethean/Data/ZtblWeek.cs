using System;
using System.Collections.Generic;

namespace Mission_10_Phethean.Data;

public partial class ZtblWeek
{
    public DateOnly WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
