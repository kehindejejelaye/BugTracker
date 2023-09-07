using System.ComponentModel.DataAnnotations;

namespace BugTracker.Entities;

public class Permission
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
}
