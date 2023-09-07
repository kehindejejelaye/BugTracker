using BugTracker.Contexts;
using BugTracker.Entities;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class ProjectHasUsersRepository : BaseRepository<ProjectHasUsers>, IProjectHasUsersRepository
{
    public ProjectHasUsersRepository(BugTrackerContext context) : base(context) { }
}
