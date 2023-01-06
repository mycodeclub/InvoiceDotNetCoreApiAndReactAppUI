using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class AspNetUserClaim
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;
}
