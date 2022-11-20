using otus.dz.DataAccess.Interfaces.Repositories;
using otus.dz.Domain.Models;

namespace otus.dz.DataAccess.PostgreSQL.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}