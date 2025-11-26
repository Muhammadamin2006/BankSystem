namespace BankSystem.Application.Dtos;

public class ClientDto
{
    public Guid ClientId { get; set; }
    //public required string SurName { get; set; } 
    public required string Name { get; set; }
    // public required string FathersName { get; set; }
    //
    public required string PassportNumber { get; set; } 
    // public required DateTime IssuedDate { get; set; } 
    // public required DateTime ExpiryDate { get; set; }
    // public required string PlaceOfBirth { get; set; }
    // public required string Address { get; set; }
    // public required string Gender {get; set; }
    // public required string Nationality { get; set; }
    //
    // public string ClientStatus { get; set; } = string.Empty;
    //
    // public string Email { get; set; } 
    // public string PhoneNumber { get; set; } 
}