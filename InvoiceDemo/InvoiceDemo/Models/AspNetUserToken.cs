﻿using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class AspNetUserToken
{
    public string UserId { get; set; } = null!;

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;
}
