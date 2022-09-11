namespace VendingMachine.Exceptions;

public class InvalidAmountException : Exception
{
    public InvalidAmountException(int amount) :
        base($"Amount must be greater than 0: {amount}") { }
}