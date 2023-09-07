using BugTracker.Contexts;
using BugTracker.Entities;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class CommentRepository : BaseRepository<Comment>, ICommentRepository
{
    public CommentRepository(BugTrackerContext context) : base(context)
    {
    }
}
