using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Domain.Entities.Account;

public class Deposite
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required Client ClientId { get; set; } 
    public required Account AccountId { get; set; } 
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public required DepositeType DepositeTypeId { get; set; }
    
    public required decimal StartMoney { get; set; }
    public required Currency.Currency CurrencyId { get; set; }
    
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}