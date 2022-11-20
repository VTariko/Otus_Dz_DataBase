using MediatR;
using otus.dz.DataAccess.Interfaces.Repositories;
using otus.dz.Domain.Models;

namespace otus.dz.UseCases;

public class CommonHandler : IRequestHandler<CommonQuery, Common>
{
    private readonly IUserRepository _userRepository;
    private readonly ICardRepository _cardRepository;
    private readonly IBankAccountRepository _bankAccountRepository;

    public CommonHandler(IUserRepository userRepository, ICardRepository cardRepository,
        IBankAccountRepository bankAccountRepository)
    {
        _userRepository = userRepository;
        _cardRepository = cardRepository;
        _bankAccountRepository = bankAccountRepository;
    }


    public async Task<Common> Handle(CommonQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync(cancellationToken);
        var cards = await _cardRepository.GetAllAsync(cancellationToken);
        var bankAccounts = await _bankAccountRepository.GetAllAsync(cancellationToken);

        return new Common
        {
            Users = users,
            Cards = cards,
            BankAccounts = bankAccounts
        };
    }
}