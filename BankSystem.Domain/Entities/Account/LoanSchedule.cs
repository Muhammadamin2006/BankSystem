namespace BankSystem.Domain.Entities.Account;

public class LoanSchedule
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required Loan LoanId { get; set; }
    
    public DateTime PaymentDate { get; set; }
    public decimal MinPaymentAmount { get; set; }
    
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } =  DateTime.Now;
}