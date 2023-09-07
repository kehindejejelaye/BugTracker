using BugTracker.Contexts;
using BugTracker.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly BugTrackerContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(BugTrackerContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = context.Set<TEntity>();
    }

    public TEntity GetById(object id)
    {
        return _dbSet.Find(id);
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public IQueryable<TEntity> Find(Func<TEntity, bool> predicate)
    {
        return _dbSet.Where(predicate).AsQueryable();
    }

    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(TEntity entity)
    {
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }
        _dbSet.Remove(entity);
    }
}


