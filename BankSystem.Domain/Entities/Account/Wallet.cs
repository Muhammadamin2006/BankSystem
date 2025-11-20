using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Domain.Entities.Account;

public class Wallet
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required Client ClientId { get; set; }
    public required Account AccountId { get; set; }
    
    public decimal Balance { get; set; }
    
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; } =  true;
    public DateTime UpdatedDate { get; set; } =  DateTime.Now;
    
}