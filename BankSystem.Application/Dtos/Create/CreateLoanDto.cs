using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Account;
using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Application.Dtos.Create;

public class CreateLoanDto
{
    public required Client ClientId { get; set; }
    public required Account AccountId { get; set; }
    public required Employee EmployeeId { get; set; }
    public required Branche BrancheId { get; set; }
    
    public required LoanType LoanTypeId { get; set; } 
    public required decimal LoanTotalAmount { get; set; }
    
    public required PaymentFrequencyType PaymentFrequencyTypeId { get; set; }
    
}