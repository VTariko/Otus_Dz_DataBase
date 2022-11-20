using MediatR;
using otus.dz.DataAccess.Interfaces.Repositories;
using otus.dz.Domain.Models;

namespace otus.dz.UseCases.UserHandlers.GetAllUsers;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository _userRepository;
    
    public GetAllUsersHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAllAsync(cancellationToken);
    }
}