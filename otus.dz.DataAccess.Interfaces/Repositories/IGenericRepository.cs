namespace otus.dz.DataAccess.Interfaces.Repositories;

public interface IGenericRepository<TEntity>
{
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task<TEntity> FindById<TId>(TId id);
    public void Add(TEntity entity);
    public Task Remove<TId>(TId id);
    public void Remove(TEntity entityToDelete);
    public void Update(TEntity entityToUpdate);
}