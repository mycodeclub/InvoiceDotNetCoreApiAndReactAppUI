using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class InvoicDtocustomer
{
    public int UniqueId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Mobile1 { get; set; }

    public string? Mobile2 { get; set; }

    public string? EmailId { get; set; }

    public string? GstNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual ICollection<Invoic> Invoics { get; } = new List<Invoic>();
}
