namespace VendingMachine.Exceptions;

public class InvalidCoinException : Exception
{
    public InvalidCoinException(string coin) :
        base($"This coin is not accepted: {coin}") { }
}