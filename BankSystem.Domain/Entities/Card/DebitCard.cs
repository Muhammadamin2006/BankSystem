using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Domain.Entities.Card;

public class DebitCard
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required Account.Account AccountId { get; set; }
    public required Client ClientId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    
    public required DebitCardType  CreditCardTypeId { get; set; }
    public required string CardNumber { get; set; }
    public required string Cvv { get; set; }
    public required DateTime ExpiryDate { get; set; }
    
    public decimal Balance { get; set; }
    
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; } =  true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}