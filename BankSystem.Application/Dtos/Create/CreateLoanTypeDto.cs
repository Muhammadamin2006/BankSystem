using BankSystem.Domain.Entities.Account;

namespace BankSystem.Application.Dtos.Create;

public class CreateLoanTypeDto
{
    public required string Type { get; set; }
    public required decimal Rate { get; set; }
    public string? LoanTerm { get; set; }
    
    public required bool HasCollateral { get; set; }
    public required CollateralType CollateralTypeId { get; set; } 
}