using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class EducationBoardsMaster
{
    public int UniqueId { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual ICollection<RegistrationForm> RegistrationForms { get; } = new List<RegistrationForm>();
}
