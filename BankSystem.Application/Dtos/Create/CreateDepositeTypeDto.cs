namespace BankSystem.Application.Dtos.Create;

public class CreateDepositeTypeDto
{
    public required string Type { get; set; }
    public required string Name { get; set; }
    public decimal Rate { get; set; }
    
    public bool CanReplenish { get; set; }
    public bool CanWithdraw { get; set; }
}