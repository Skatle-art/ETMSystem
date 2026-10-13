using System;
using System.Collections.Generic;

namespace ETMSystem.Models;

public partial class Driver
{
    public int DriverId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string? Email { get; set; }

    public string LicenseNo { get; set; } = null!;

    public DateOnly LicenseExpiryDate { get; set; }

    public string EmploymentStatus { get; set; } = null!;

    public string? EmergencyContact { get; set; }

    public virtual ICollection<Travel> Travels { get; set; } = new List<Travel>();
}
