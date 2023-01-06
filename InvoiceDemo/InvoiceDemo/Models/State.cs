using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class State
{
    public int UniqueId { get; set; }

    public int CountryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<City> Cities { get; } = new List<City>();

    public virtual Country Country { get; set; } = null!;
}
