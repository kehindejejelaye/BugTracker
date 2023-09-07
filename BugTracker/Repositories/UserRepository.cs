using BugTracker.Contexts;
using BugTracker.Entities;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(BugTrackerContext context) : base(context)
    {
    }
}
