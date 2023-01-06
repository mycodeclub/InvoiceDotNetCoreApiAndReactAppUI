using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Career
{
    public int UniqueId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string? PositionAppliedFor { get; set; }

    public string? ResumeFileName { get; set; }

    public bool IsReviewed { get; set; }

    public string? AddComment { get; set; }

    public string? Message { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }
}
