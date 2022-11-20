using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using otus.dz.Domain.Models;
using otus.dz.UseCases.UserHandlers.AddUser;
using otus.dz.UseCases.UserHandlers.GetAllUsers;
using otus.dz.WebApi.Models.User;

namespace otus.dz.WebApi.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UserController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet("get-all")]
    public async Task<List<UserDto>> GetAllUsers()
    {
        var query = new GetAllUsersQuery();
        var resultQuery = await _mediator.Send(query);
        var result =  _mapper.Map<List<UserDto>>(resultQuery);
       
        return result;
    }

    [HttpPost("add")]
    public async Task AddUser(UserDto user)
    {
        var command = new AddUserCommand
        {
            User = _mapper.Map<User>(user) 
        };
        await _mediator.Send(command);
    }
}