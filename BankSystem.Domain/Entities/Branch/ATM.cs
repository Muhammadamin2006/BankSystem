namespace BankSystem.Domain.Entities.Branch;

public class ATM
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public string Location { get; set; } =  string.Empty;
    public decimal Balance { get; set; } 
    
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}