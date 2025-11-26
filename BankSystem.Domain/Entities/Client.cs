using System.Text.RegularExpressions;

namespace BankSystem.Domain.Entities;

public class Client
{
    public Guid ClientId { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public string PassportNumber { get; private set; }

    public Client() { }
    
    public Client(string name, string passportNumber)
    {
        SetName(name);
        SetPassportNumber(passportNumber);
    }
    
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new DomainException("Name can't be empty");
        if (!Regex.IsMatch(name, @"^[A-Z][a-z]+$"))
            throw new DomainException("Name must start with a capital letter and contain only lowercase letters after it");
        
        Name = name;
    }

    public void SetPassportNumber(string passportNumber)
    {
        if (string.IsNullOrEmpty(passportNumber))
            throw new DomainException("Passport number can't be empty");
        if (passportNumber.Length != 7)
            throw new DomainException("Passport number must be 7 digits");
        
        PassportNumber = passportNumber;
    }

}














// public required string SurName { get; set; } 
    // public required string FathersName { get; set; }
    // public string ClientStatus { get; set; } =  string.Empty;
    //
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
    //public ICollection<Account.Account> Accounts { get; set; }  = new List<Account.Account>();
