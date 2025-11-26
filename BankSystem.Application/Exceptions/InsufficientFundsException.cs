namespace BankSystem.Application.Exceptions;

//недостаточно средств
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}