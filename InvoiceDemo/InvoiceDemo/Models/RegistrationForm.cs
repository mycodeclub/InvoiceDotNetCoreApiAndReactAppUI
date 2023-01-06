using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class RegistrationForm
{
    public int UniqueId { get; set; }

    public int? StatusId { get; set; }

    public string? TotalFees { get; set; }

    public string? Discount { get; set; }

    public string? RegistrationId { get; set; }

    public string FullName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string? CurrentlyPursuing { get; set; }

    public string? CollegeName { get; set; }

    public int? BoardId { get; set; }

    public string HighestQualification { get; set; } = null!;

    public int? ApplicationFor { get; set; }

    public string? Message { get; set; }

    public string MobileNumber { get; set; } = null!;

    public string? AlternateMobileNumber { get; set; }

    public string EmailId { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public virtual CourseCategory? ApplicationForNavigation { get; set; }

    public virtual EducationBoardsMaster? Board { get; set; }

    public virtual ICollection<Fee> Fees { get; } = new List<Fee>();

    public virtual RegistrationStatusMaster? Status { get; set; }
}
