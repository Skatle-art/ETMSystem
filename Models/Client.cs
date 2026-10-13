using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string? Email { get; set; }

    public string Address { get; set; } = null!;

    public string? JobTitle { get; set; }

    public string? EmergencyContact { get; set; }

    public string ClientStatus { get; set; } = null!;

    public virtual ICollection<ClientTravel> ClientTravels { get; set; } = new List<ClientTravel>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ProspectClient? ProspectClient { get; set; }

    public virtual User? User { get; set; }
}
