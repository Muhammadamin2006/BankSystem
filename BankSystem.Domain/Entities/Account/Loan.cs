using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Domain.Entities.Account;

public class Loan
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required Client ClientId { get; set; }
    public required Account AccountId { get; set; }
    public required Employee EmployeeId { get; set; }
    public required Branche BrancheId { get; set; }
    
    public DateTime CreatedDate { get; set; } =   DateTime.Now;
    public required LoanType LoanTypeId { get; set; } 
    public required decimal LoanTotalAmount { get; set; }
    
    public required PaymentFrequencyType PaymentFrequencyTypeId { get; set; }
    public required decimal RemainingDept { get; set; }
    
    public DateTime EndDate { get; set; } 
    public bool IsActive { get; set; } = true;  
    public DateTime UpdatedDate { get; set; } =   DateTime.Now;
}