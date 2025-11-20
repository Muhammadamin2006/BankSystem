using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Account;
using BankSystem.Domain.Entities.Branch;
using BankSystem.Domain.Entities.Card;

namespace BankSystem.Application.Dtos.Create;

public class CreateCreditCardDto
{
    public required Account AccountId { get; set; }
    public required Client ClientId { get; set; }
    public required string GracePeriod { get; set; }
    
    public required CreditCardType  CreditCardTypeId { get; set; }
    public required string CardNumber { get; set; }
    public required string Cvv { get; set; }
    public required DateTime ExpiryDate { get; set; }
    
    public required decimal Amount { get; set; }
}