using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class BankAccount
{
    public int UniqueId { get; set; }

    public string? AccountHolderName { get; set; }

    public string? Ifsccode { get; set; }

    public string? BankName { get; set; }

    public string? AccountNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual ICollection<InvoicDtomerchant> InvoicDtomerchants { get; } = new List<InvoicDtomerchant>();
}
