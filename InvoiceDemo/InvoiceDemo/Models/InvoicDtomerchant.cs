using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class InvoicDtomerchant
{
    public int UniqueId { get; set; }

    public string? OrgName { get; set; }

    public string? OrgLogoUri { get; set; }

    public string? Address { get; set; }

    public string? Mobile1 { get; set; }

    public string? Mobile2 { get; set; }

    public string? EmailId { get; set; }

    public string? GstNumber { get; set; }

    public int? AccountDetailsUniqueId { get; set; }

    public virtual BankAccount? AccountDetailsUnique { get; set; }
}
