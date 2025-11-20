using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Account;
using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Application.Dtos.Create;

public class CreateWalletDto
{
    public required Client ClientId { get; set; }
    public required Account AccountId { get; set; }
}