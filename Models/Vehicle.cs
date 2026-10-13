using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string MakeModel { get; set; } = null!;

    public int SeatCapacity { get; set; }

    public string VehicleStatus { get; set; } = null!;

    public DateOnly? LastMaintenanceDate { get; set; }

    public virtual ICollection<Travel> Travels { get; set; } = new List<Travel>();
}
