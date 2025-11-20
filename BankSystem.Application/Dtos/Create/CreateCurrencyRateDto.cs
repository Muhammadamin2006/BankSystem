using BankSystem.Domain.Entities.Currency;

namespace BankSystem.Application.Dtos.Create;

public class CreateCurrencyRateDto
{
    public required Currency FromCurrencyId { get; set; }
    public required Currency ToCurrencyId { get; set; }
    
    public required decimal Rate { get; set; }
}