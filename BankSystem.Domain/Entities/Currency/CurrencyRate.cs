namespace BankSystem.Domain.Entities.Currency;

public class CurrencyRate
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public required Entities.Currency.Currency FromCurrencyId { get; set; }
    public required Entities.Currency.Currency ToCurrencyId { get; set; }
    
    public required DateTime RateDate { get; set; } = DateTime.Now;
    
    public required decimal Rate { get; set; }
    
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}