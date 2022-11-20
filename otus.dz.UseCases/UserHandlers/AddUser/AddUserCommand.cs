using MediatR;

namespace otus.dz.UseCases.UserHandlers.AddUser;

public class AddUserCommand : IRequest
{
    public Domain.Models.User User { get; set; } = null!;
}