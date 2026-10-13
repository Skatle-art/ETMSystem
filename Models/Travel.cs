using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class Travel
{
    public int TravelId { get; set; }

    public int DriverId { get; set; }

    public int VehicleId { get; set; }

    public TimeOnly PickupTime { get; set; }

    public TimeOnly DropOffTime { get; set; }

    public TimeOnly? ReturnPickupTime { get; set; }

    public DateOnly TravelRouteDate { get; set; }

    public int? NumberOfClients { get; set; }

    public string RouteStatus { get; set; } = null!;

    public int? TravelPeriodId { get; set; }

    public virtual ICollection<ClientTravel> ClientTravels { get; set; } = new List<ClientTravel>();

    public virtual Driver Driver { get; set; } = null!;

    public virtual TravelPeriodLookup? TravelPeriod { get; set; }

    public virtual Vehicle Vehicle { get; set; } = null!;
}
