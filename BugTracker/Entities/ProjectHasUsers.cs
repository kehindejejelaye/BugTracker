using System.ComponentModel.DataAnnotations;

namespace BugTracker.Entities;

public class ProjectHasUsers
{
    public string ProjectId { get; set; }
    public string UserId { get; set; }

    public Project Project { get; set; }
    public User User { get; set; }
}
