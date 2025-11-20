using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Account;
using BankSystem.Domain.Entities.Branch;
using BankSystem.Domain.Entities.Card;

namespace BankSystem.Application.Dtos.Create;

public class CreateDebitCardDto
{
    public required Account AccountId { get; set; }
    public required Client ClientId { get; set; }
    
    public required DebitCardType  CreditCardTypeId { get; set; }
    public required string CardNumber { get; set; }
    public required string Cvv { get; set; }
    public required DateTime ExpiryDate { get; set; }
    
}