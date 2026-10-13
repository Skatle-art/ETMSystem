using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class ClientTravel
{
    public int ClientTravelId { get; set; }

    public int ClientId { get; set; }

    public int TravelId { get; set; }

    public string PickupPoint { get; set; } = null!;

    public string DropOffPoint { get; set; } = null!;

    public string? ReturnPickupPoint { get; set; }

    public string? ReturnDropOffPoint { get; set; }

    public string AvailableStatus { get; set; } = null!;

    public string ChosenPeriod { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual Travel Travel { get; set; } = null!;
}
