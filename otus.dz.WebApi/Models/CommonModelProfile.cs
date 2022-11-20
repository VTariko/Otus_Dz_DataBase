using AutoMapper;

namespace otus.dz.WebApi.Models;

public class CommonModelProfile : Profile
{
    public CommonModelProfile()
    {
        CreateMap<otus.dz.Domain.Models.Common, CommonModelDto>();
    }
}