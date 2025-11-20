namespace BankSystem.Domain.Entities.Account;

public class DepositeHistory
{
    public required Deposite DepositeId { get; set; } 
    
    public DateTime EndDate { get; set; } 
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}