using BugTracker.Contexts;
using BugTracker.Entities;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class ProjectRepository : BaseRepository<Project>, IProjectRepository
{
    public ProjectRepository(BugTrackerContext context) : base(context)
    {
        
    }
}
