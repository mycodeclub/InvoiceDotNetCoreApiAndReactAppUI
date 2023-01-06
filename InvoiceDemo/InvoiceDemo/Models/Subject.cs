using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Subject
{
    public int UniqueId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int ParentId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public virtual ICollection<CodeHelper> CodeHelpers { get; } = new List<CodeHelper>();

    public virtual ICollection<Question> Questions { get; } = new List<Question>();
}
