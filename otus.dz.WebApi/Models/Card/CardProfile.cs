using AutoMapper;

namespace otus.dz.WebApi.Models.Card;

public class CardProfile : Profile
{
    public CardProfile()
    {
        CreateMap<otus.dz.Domain.Models.Card, CardDto>();
        CreateMap<CardDto, otus.dz.Domain.Models.Card>();
    }
}