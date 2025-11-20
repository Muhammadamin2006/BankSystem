namespace BankSystem.Domain.Entities.Branch;

public class Branche
{
    public Guid Id { get; set; } =   Guid.NewGuid();
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    
    public required string Address { get; set; }
    public decimal Balance { get; set; } = 0.0m;
    public required Currency.Currency CurrencyId { get; set; }
    public string? BranchPhoneNumber { get; set; }
    public int CountOfEmployees { get; set; } = 0;
    public int CountOfClients { get; set; } = 0;
    
    public DateTime ClosedDate { get; set; } 
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}