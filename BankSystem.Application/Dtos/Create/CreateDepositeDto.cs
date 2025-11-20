using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Account;
using BankSystem.Domain.Entities.Branch;
using BankSystem.Domain.Entities.Currency;

namespace BankSystem.Application.Dtos.Create;

public class CreateDepositeDto
{
    public required Client ClientId { get; set; } 
    public required Account AccountId { get; set; } 
    public required DepositeType DepositeTypeId { get; set; }
    
    public required decimal StartMoney { get; set; }
    public required Currency CurrencyId { get; set; }
}