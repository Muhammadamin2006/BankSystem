namespace BankSystem.Domain.Entities.Account;

public class CollateralType
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required string Type { get; set; }
    public required string Description { get; set; }
    public required decimal Value { get; set; }
}