namespace VendingMachine.Exceptions;

public class InvalidCentsException : Exception
{
    public InvalidCentsException(int cents) :
        base($"Cents must be between 0 and 99: {cents}.") { }
}