﻿using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class AspNetUserLogin
{
    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public string? ProviderDisplayName { get; set; }

    public string UserId { get; set; } = null!;

    public virtual ApplicationUser User { get; set; } = null!;
}
