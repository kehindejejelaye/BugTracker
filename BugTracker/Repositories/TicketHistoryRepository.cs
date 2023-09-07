using BugTracker.Contexts;
using BugTracker.Entities;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class TicketHistoryRepository : BaseRepository<TicketHistory>, ITicketHistoryRepository
{
    public TicketHistoryRepository(BugTrackerContext context) : base(context)
    {
    }
}
