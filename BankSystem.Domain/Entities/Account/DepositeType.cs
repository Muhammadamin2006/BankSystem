namespace BankSystem.Domain.Entities.Account;

public class DepositeType
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    
    public required string Type { get; set; }
    public required string Name { get; set; }
    public decimal Rate { get; set; }
    
    public bool CanReplenish { get; set; }
    public bool CanWithdraw { get; set; }
    
    public bool IsActive { get; set; } =  true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}