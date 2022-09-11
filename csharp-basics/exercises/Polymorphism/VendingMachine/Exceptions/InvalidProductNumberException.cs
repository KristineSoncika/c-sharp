namespace VendingMachine.Exceptions;

public class InvalidProductNumberException : Exception
{
    public InvalidProductNumberException(int invalidNumber) :
        base($"Invalid product number: {invalidNumber}.") { }
}