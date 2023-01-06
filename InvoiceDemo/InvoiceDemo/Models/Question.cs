using System;
using System.Collections.Generic;

namespace InvoiceDemo.Models;

public partial class Question
{
    public int UniqueId { get; set; }

    public int SubjectId { get; set; }

    public string? QustionText { get; set; }

    public string? QustionDescription { get; set; }

    public string? AnswerLine1 { get; set; }

    public string? AnswerLine2 { get; set; }

    public string? AnswerText { get; set; }

    public string? AnswerObjectJson { get; set; }

    public string? Tags { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public bool IsActive { get; set; }

    public virtual Subject Subject { get; set; } = null!;
}
