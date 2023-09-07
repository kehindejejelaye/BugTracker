using System.ComponentModel.DataAnnotations;

namespace BugTracker.Entities;

public class Comment
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string TicketId { get; set; }
    public string Message { get; set; }
    public Ticket Ticket { get; set; }
}
