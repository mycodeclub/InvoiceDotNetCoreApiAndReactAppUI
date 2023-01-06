using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class JobApplication
{
    public int UniqueId { get; set; }

    public string Name { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string? AlternateNumber { get; set; }

    public string ApplicationFor { get; set; } = null!;

    public short ExperienceYears { get; set; }

    public short ExperienceMonths { get; set; }

    public string? MessageText { get; set; }

    public string? MessageHeading { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsReviewed { get; set; }

    public string? ReviewUpdate { get; set; }

    public bool IsActive { get; set; }
}
