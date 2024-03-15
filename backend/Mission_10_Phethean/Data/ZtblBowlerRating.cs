using System;
using System.Collections.Generic;

namespace Mission_10_Phethean.Data;

public partial class ZtblBowlerRating
{
    public string BowlerRating { get; set; } = null!;

    public short? BowlerLowAvg { get; set; }

    public short? BowlerHighAvg { get; set; }
}
