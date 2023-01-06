using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Course
{
    public int UniqueId { get; set; }

    public string CourseName { get; set; } = null!;

    public int CourseCategoryId { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual CourseCategory CourseCategory { get; set; } = null!;
}
