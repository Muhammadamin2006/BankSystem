namespace BankSystem.Application.Dtos.Create;

public class CreateCurrencyDto
{
    public required string Code { get; set; }
    public required string Country { get; set; }
}