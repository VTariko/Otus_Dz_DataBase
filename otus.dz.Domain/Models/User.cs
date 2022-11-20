using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otus.dz.Domain.Models;

[Table("sber_users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("first_name")]
    public string FirstName { get; set; } = null!;
    
    [Column("second_name")]
    public string SecondName { get; set; } = null!;
    
    [Column("middle_name")]
    public string MiddleName { get; set; } = null!;
    
    [Column("passport_series")]
    public string PassportSeries { get; set; } = null!;
    
    [Column("passport_number")]
    public long PassportNumber { get; set; }
}