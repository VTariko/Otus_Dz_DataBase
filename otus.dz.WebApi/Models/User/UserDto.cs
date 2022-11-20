namespace otus.dz.WebApi.Models.User;

public class UserDto
{
    public string FirstName { get; set; } = null!;
    public string SecondName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string PassportSeries { get; set; } = null!;
    public string PassportNumber { get; set; } = null!;
}