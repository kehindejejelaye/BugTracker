using System.ComponentModel.DataAnnotations;

namespace BugTracker.Entities;

public class Project
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; }
    public string Description { get; set; }
}
