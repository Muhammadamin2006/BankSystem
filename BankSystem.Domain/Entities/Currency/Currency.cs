namespace BankSystem.Domain.Entities.Currency;

public class Currency
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public string Code { get; set; }
    public string Country { get; set; }

    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;   
}