using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Application.Dtos.Create;

public class CreateEmployeeDto
{
    public required Branche BrancheId { get; set; }
    
    public required string FirstName { get; set; }
    public required string LastName { get; set; }   
    public required string Position { get; set; }
    
    public decimal Salary { get; set; }   
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    
}