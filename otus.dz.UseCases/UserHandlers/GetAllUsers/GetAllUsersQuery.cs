using MediatR;
using otus.dz.Domain.Models;

namespace otus.dz.UseCases.UserHandlers.GetAllUsers;

public class GetAllUsersQuery : IRequest<List<User>>
{
}