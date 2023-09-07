using BugTracker.Contexts;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class RoleRepository : BaseRepository<RoleRepository>, IRoleRepository
{
    public RoleRepository(BugTrackerContext context) : base(context)
    {
        
    }
}
