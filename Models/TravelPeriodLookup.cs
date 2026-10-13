using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class TravelPeriodLookup
{
    public int TravelPeriodId { get; set; }

    public string PeriodName { get; set; } = null!;

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public string PeriodType { get; set; } = null!;

    public virtual ICollection<Travel> Travels { get; set; } = new List<Travel>();
}
