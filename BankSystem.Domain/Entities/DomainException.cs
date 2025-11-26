namespace BankSystem.Domain.Entities;

public class DomainException : Exception
{
    public DomainException(string message) : base(message) { }
}