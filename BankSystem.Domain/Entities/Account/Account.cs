using System.ComponentModel.DataAnnotations.Schema;
using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Domain.Entities.Account;

public class Account
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    
    public Guid ClientId { get; set; }              // FK
    public required Client Client { get; set; }    // Навигационное свойство
    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    
    public required string Type { get; set; }
    public required Guid TypeId { get; set; } 
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Balance { get; set; } = 0.0M;
    
    public Guid CurrencyId { get; set; }
    public required Currency.Currency Currency  { get; set; }
    
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}