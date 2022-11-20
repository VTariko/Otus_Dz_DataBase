using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using otus.dz.UseCases;
using otus.dz.WebApi.Models;

namespace otus.dz.WebApi.Controllers;

[ApiController]
[Route("common")]
public class CommonController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public CommonController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet("get-all")]
    public async Task<CommonModelDto> GetAllTables()
    {
        var query = new CommonQuery();
        var resultQuery = await _mediator.Send(query);
        var result =  _mapper.Map<CommonModelDto>(resultQuery);
       
        return result;
    }
}