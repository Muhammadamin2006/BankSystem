namespace BankSystem.Domain.Entities.Branch;

public class AtmLoadsHistory
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required ATM AtmId { get; set; } 
    public required Employee EmployeeId { get; set; }
    public required string Description { get; set; }
    public decimal OldBalance { get; set; }
    public decimal NewBalance { get; set; }
    
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}