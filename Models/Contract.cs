using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class Contract
{
    public int ContractId { get; set; }

    public int ClientId { get; set; }

    public DateOnly ContractStartDate { get; set; }

    public DateOnly ContractEndDate { get; set; }

    public decimal MonthlyFee { get; set; }

    public byte PaymentDue { get; set; }

    public string TransportPeriod { get; set; } = null!;

    public string PickupLocation { get; set; } = null!;

    public string DropOffLocation { get; set; } = null!;

    public string ContractStatus { get; set; } = null!;

    public bool TermsConditionsAcceptance { get; set; }

    public DateTime DateCreated { get; set; }

    public virtual Client Client { get; set; } = null!;
}
