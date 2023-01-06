using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Fee
{
    public int UniqueId { get; set; }

    public int StudentId { get; set; }

    public string? FeeInstallment { get; set; }

    public DateTime FeeSubmittingDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public virtual RegistrationForm Student { get; set; } = null!;
}
