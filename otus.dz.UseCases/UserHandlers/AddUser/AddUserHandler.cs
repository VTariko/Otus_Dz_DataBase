using MediatR;
using otus.dz.DataAccess.Interfaces;
using otus.dz.DataAccess.Interfaces.Repositories;

namespace otus.dz.UseCases.UserHandlers.AddUser;

public class AddUserHandler : AsyncRequestHandler<AddUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddUserHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    protected override async Task Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        _userRepository.Add(request.User);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}