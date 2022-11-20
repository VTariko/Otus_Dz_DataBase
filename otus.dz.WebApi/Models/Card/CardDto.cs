using otus.dz.WebApi.Models.BankAccount;

namespace otus.dz.WebApi.Models.Card;

public class CardDto
{
    public string CardNumber { get; set; } = null!;
    public string ValidityPeriodMonth { get; set; } = null!;
    public string ValidityPeriodYear { get; set; } = null!;
    public BankAccountDto BankAccount { get; set; } = null!;
}