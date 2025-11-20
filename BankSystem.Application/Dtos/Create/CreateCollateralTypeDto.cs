namespace BankSystem.Application.Dtos.Create;

public class CreateCollateralTypeDto
{
    public required string Type { get; set; }
    public required string Description { get; set; }
    public required decimal Value { get; set; }
}