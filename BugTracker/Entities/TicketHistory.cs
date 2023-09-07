using System.ComponentModel.DataAnnotations;

namespace BugTracker.Entities;

public class TicketHistory
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string TicketId { get; set; }
    public string ModifiedFields { get; set; }
    public string OldValues { get; set; }
    public string NewValues { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
