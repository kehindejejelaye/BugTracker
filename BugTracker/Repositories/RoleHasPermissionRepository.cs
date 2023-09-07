using BugTracker.Contexts;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class RoleHasPermissionRepository : BaseRepository<RoleHasPermissionRepository>, IRoleHasPermissionRepository
{
    public RoleHasPermissionRepository(BugTrackerContext context) : base(context)
    {
        
    }
}
