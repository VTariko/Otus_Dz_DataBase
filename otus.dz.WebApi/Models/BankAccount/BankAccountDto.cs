using otus.dz.WebApi.Models.User;

namespace otus.dz.WebApi.Models.BankAccount;

public class BankAccountDto
{
    public long AccountNumber { get; set; }
    public string Currency { get; set; } = null!;
    public UserDto User { get; set; } = null!;
}