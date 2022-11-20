using otus.dz.WebApi.Models.BankAccount;
using otus.dz.WebApi.Models.Card;
using otus.dz.WebApi.Models.User;

namespace otus.dz.WebApi.Models;

public class CommonModelDto
{
    public List<UserDto> Users { get; set; }
    public List<CardDto> Cards { get; set; }
    public List<BankAccountDto> BankAccounts { get; set; }
}