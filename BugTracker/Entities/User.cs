using System.ComponentModel.DataAnnotations;

namespace BugTracker.Entities;

public class User
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Email { get; set; }
    public string FirstName { get; set; }
    public DateTime? VerifiedAt { get; set; }
}
