using System;
using TechNotes.Domain.Abstractions;

namespace TechNotes.Domain.Notes;

public class Note : Entity
{
    //public int Id { get; set; }
    public required string Title { get; set; }
    public string? Content { get; set; }
    //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? PublishedAt { get; set; }
    public bool IsPublished { get; set; } = false;

}
