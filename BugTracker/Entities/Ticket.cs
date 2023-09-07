using BugTracker.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Entities;

public class Ticket
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; }
    public string Description { get; set; }
    public string? AssignedDeveloperId { get; set; }
    public string SubmitterId { get; set; }
    public TicketPriority Priority { get; set; } = TicketPriority.None;
    public TicketStatus Status { get; set; } = TicketStatus.New;
    public TicketType Type { get; set; }
    public string ProjectId { get; set; }
    public Project Project { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastModified { get; set; }
}
