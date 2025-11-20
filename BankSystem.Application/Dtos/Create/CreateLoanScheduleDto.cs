using BankSystem.Domain.Entities.Account;

namespace BankSystem.Application.Dtos.Create;

public class CreateLoanScheduleDto
{
    public required Loan LoanId { get; set; }
    
    public DateTime PaymentDate { get; set; }
    public decimal MinPaymentAmount { get; set; }
}