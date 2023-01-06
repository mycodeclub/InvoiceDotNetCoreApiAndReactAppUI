using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Enquiry
{
    public int UniqueId { get; set; }

    public string Name { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string? AltContactNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
