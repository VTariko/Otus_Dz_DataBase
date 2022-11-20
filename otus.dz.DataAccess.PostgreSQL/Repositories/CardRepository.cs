using otus.dz.DataAccess.Interfaces.Repositories;
using otus.dz.Domain.Models;

namespace otus.dz.DataAccess.PostgreSQL.Repositories;

public class CardRepository : GenericRepository<Card>, ICardRepository
{
    private readonly AppDbContext _context;
    
    public CardRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}