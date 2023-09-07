using BugTracker.Contexts;
using BugTracker.Entities;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.Repositories;

public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
{
    public TicketRepository(BugTrackerContext context) : base(context)
    {

    }
}
