namespace BankSystem.Application.Exceptions;

//счет не найден
public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message) { }
}