using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Application.Dtos.Create;

public class CreateAccountDto
{
    public required Client ClientId { get; set; }
    
    public required string Type { get; set; }
    public required Guid TypeId { get; set; } 
    
    public decimal StartMoney { get; set; } = 0.0M;
}