namespace otus.dz.DataAccess.Interfaces;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken token = default);
}