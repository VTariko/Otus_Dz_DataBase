using otus.dz.DataAccess.Interfaces.Repositories;
using otus.dz.Domain.Models;

namespace otus.dz.DataAccess.PostgreSQL.Repositories;

public class BankAccountRepository : GenericRepository<BankAccount>, IBankAccountRepository
{
    private readonly AppDbContext _context;
    
    public BankAccountRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}