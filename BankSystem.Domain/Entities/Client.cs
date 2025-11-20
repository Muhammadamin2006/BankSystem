namespace BankSystem.Domain.Entities;

public class Client
{
    public Guid ClientId { get; set; } 
    public required string Name { get; set; }
    // public required string SurName { get; set; } 
    // public required string FathersName { get; set; }
    // public string ClientStatus { get; set; } =  string.Empty;
    //
    public required string PassportNumber { get; set; } 
    // public required DateTime IssuedDate { get; set; } 
    // public required DateTime ExpiryDate { get; set; }
    // public required string PlaceOfBirth { get; set; }
    // public required string Address { get; set; }
    // public required string Gender {get; set; }
    // public required string Nationality { get; set; }
    //
    // public string Email { get; set; } = string.Empty;
    // public string PhoneNumber { get; set; } =  string.Empty;
    //
    // public bool IsActive { get; set; } 
    // public DateTime UpdatedDate { get; set; } 
}