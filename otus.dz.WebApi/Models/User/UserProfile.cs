using AutoMapper;

namespace otus.dz.WebApi.Models.User;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<otus.dz.Domain.Models.User, UserDto>();
        CreateMap<UserDto, otus.dz.Domain.Models.User>();
    }
}