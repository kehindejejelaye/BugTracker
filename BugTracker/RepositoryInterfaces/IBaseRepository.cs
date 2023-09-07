namespace BugTracker.RepositoryInterfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    TEntity GetById(object id);
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}