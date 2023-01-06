using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; } = new List<AspNetRoleClaim>();

    public virtual ICollection<ApplicationUser> Users { get; } = new List<ApplicationUser>();
}
