namespace BankSystem.Domain.Entities.Card;

public class DebitCardType
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public string? Name { get; set; }
}