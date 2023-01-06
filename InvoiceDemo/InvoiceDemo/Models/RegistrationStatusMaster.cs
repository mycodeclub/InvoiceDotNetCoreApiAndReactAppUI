using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class RegistrationStatusMaster
{
    public int UniqueId { get; set; }

    public string RegistrationStatus { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public virtual ICollection<RegistrationForm> RegistrationForms { get; } = new List<RegistrationForm>();
}
