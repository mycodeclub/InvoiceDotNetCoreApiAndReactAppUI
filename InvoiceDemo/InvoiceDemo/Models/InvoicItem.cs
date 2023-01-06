using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class InvoicItem
{
    public int UniqueId { get; set; }

    public int InvoiceId { get; set; }

    public string? ProductServiceDescription { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal UnitCounts { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public virtual Invoic Invoice { get; set; } = null!;
}
