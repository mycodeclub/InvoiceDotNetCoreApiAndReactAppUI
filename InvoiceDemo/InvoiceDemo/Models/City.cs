using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class City
{
    public int UniqueId { get; set; }

    public int StateId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual State State { get; set; } = null!;
}
