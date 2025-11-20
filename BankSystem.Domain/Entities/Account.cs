namespace Bank.Domain.Entities;

public class Account
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required Client ClientId { get; set; }
    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    
    public required string Type { get; set; }
    public required Guid TypeId { get; set; } 
    
    public decimal Balance { get; set; } = 0.0M;
    public required Currency CurrencyId { get; set; }
    
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}