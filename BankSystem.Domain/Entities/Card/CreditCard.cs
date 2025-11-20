using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Domain.Entities.Card;

public class CreditCard
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required Account.Account AccountId { get; set; }
    public required Client ClientId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public required string GracePeriod { get; set; }
    
    public required CreditCardType  CreditCardTypeId { get; set; }
    public required string CardNumber { get; set; }
    public required string Cvv { get; set; }
    public required DateTime ExpiryDate { get; set; }
    
    public required decimal Amount { get; set; }
    public decimal SpentMoney { get; set; }
    public decimal RemainingMoney { get; set; }
    
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; } =  true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
    
}