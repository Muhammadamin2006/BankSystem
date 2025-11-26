namespace BankSystem.Application.Dtos;

public class UpdateClientDto
{
    public required string NewName { get; set; }
    public required string PassportNumber { get; set; } 
}