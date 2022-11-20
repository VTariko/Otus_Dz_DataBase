using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otus.dz.Domain.Models;

[Table("cards")]
public class Card
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("card_number")]
    public string CardNumber { get; set; } = null!;
    
    [Column("validity_period_month")]
    public string ValidityPeriodMonth { get; set; } = null!;
    
    [Column("validity_period_year")]
    public string ValidityPeriodYear { get; set; } = null!;
    
    [ForeignKey("account_id")]
    public BankAccount BankAccount { get; set; }
}