using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Country
{
    public int UniqueId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<State> States { get; } = new List<State>();
}
