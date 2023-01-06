using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Address
{
    public int UniqueId { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? NearestLandMark { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public int? CountryId { get; set; }

    public string PinCode { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; } = new List<ApplicationUser>();

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual State? State { get; set; }
}
