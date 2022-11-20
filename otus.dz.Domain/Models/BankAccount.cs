using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otus.dz.Domain.Models;

[Table("bank_accounts")]
public class BankAccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("account_number")]
    public long AccountNumber { get; set; }
    
    [Column("currency")]
    public string Currency { get; set; } = null!;
    
    [ForeignKey("user_id")]
    public User User { get; set; }
}