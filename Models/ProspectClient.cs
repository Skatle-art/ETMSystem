using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class ProspectClient
{
    public int ClientId { get; set; }

    public string LeadSource { get; set; } = null!;

    public string? ReasonNotJoined { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public virtual Client Client { get; set; } = null!;
}
