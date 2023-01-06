using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class InvoicPayment
{
    public int UniqueId { get; set; }

    public int BaseInvoiceId { get; set; }

    public decimal ReceivedAmount { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual Invoic BaseInvoice { get; set; } = null!;
}
