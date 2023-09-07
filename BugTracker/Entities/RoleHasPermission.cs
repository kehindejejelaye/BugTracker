using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Entities;

public class RoleHasPermission
{
    public string RoleId { get; set; }
    public string PermissionId { get; set; }

    public Role Role { get; set; }
    public Permission Permission { get; set; }
}
