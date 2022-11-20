using AutoMapper;

namespace otus.dz.WebApi.Models.BankAccount;

public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {
        CreateMap<otus.dz.Domain.Models.BankAccount, BankAccountDto>();
        CreateMap<BankAccountDto, otus.dz.Domain.Models.BankAccount>();
    }
}