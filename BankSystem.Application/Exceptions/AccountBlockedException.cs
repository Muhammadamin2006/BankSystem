namespace BankSystem.Application.Exceptions;

//счет заблокирован
public class AccountBlockedException : Exception
{
    public AccountBlockedException(string message) : base(message) { }
}