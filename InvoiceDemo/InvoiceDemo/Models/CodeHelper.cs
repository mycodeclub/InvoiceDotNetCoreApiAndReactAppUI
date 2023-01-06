using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class CodeHelper
{
    public int UniqueId { get; set; }

    public int SubjectId { get; set; }

    public string? Topic { get; set; }

    public string? TopicDescription { get; set; }

    public string? AnswerLine1 { get; set; }

    public string? AnswerText { get; set; }

    public string? Tags { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public bool IsActive { get; set; }

    public virtual Subject Subject { get; set; } = null!;
}
