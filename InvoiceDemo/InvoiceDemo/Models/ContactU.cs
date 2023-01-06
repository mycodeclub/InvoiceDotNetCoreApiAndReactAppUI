using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class ContactU
{
    public int UniqueId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public bool IsReviewed { get; set; }

    public string? ReviewerResponce { get; set; }

    public DateTime CreatedDate { get; set; }
}
