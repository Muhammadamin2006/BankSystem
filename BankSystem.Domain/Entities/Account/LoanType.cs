namespace BankSystem.Domain.Entities.Account;

public class LoanType
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    
    public required string Type { get; set; }
    public required decimal Rate { get; set; }
    public string? LoanTerm { get; set; }
    
    public required bool HasCollateral { get; set; }
    public required CollateralType CollateralTypeId { get; set; }  
    
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}