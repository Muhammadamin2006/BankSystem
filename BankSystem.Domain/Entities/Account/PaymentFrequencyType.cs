namespace BankSystem.Domain.Entities.Account;

public class PaymentFrequencyType
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public string? Type { get; set; }
}