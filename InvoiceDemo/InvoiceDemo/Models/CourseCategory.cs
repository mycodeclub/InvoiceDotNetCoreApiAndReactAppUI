using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class CourseCategory
{
    public int UniqueId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<RegistrationForm> RegistrationForms { get; } = new List<RegistrationForm>();
}
