using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Invoic
{
    public int UniqueId { get; set; }

    public int CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Description { get; set; }

    public decimal GrandTotal { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal DiscountAmount { get; set; }

    public string? DiscountTypeName { get; set; }

    public decimal BillableAmountAfterDiscount { get; set; }

    public decimal TotalPaid { get; set; }

    public decimal RemainingBalance { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public bool IsBillingCompleted { get; set; }

    public virtual InvoicDtocustomer Customer { get; set; } = null!;

    public virtual ICollection<InvoicItem> InvoicItems { get; } = new List<InvoicItem>();

    public virtual ICollection<InvoicPayment> InvoicPayments { get; } = new List<InvoicPayment>();
}
