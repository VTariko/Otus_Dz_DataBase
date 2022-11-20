using Microsoft.EntityFrameworkCore;
using otus.dz.DataAccess.Interfaces.Repositories;

namespace otus.dz.DataAccess.PostgreSQL.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> FindById<TId>(TId id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual void Add(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public virtual async Task Remove<TId>(TId id)
    {
        var entityToDelete = await _dbSet.FindAsync(id);
        Remove(entityToDelete);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }
    public virtual void Remove(TEntity entityToDelete)
    {
        _dbSet.Remove(entityToDelete);
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        _dbSet.Update(entityToUpdate);
    }
}