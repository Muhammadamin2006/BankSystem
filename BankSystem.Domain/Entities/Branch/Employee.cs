namespace BankSystem.Domain.Entities.Branch;

public class Employee
{
    public Guid Id { get; set; } =   Guid.NewGuid();
    public required Branche BrancheId { get; set; }
    
    public DateTime HireDate { get; set; } = DateTime.Now;
    
    public required string FirstName { get; set; }
    public required string LastName { get; set; }   
    public required string Position { get; set; }
    
    public decimal Salary { get; set; }   
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
    
}

