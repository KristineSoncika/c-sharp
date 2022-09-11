namespace VendingMachine.Exceptions;

public class NotEnoughEmptySpotsException : Exception
{
    public NotEnoughEmptySpotsException(int spots) :
        base($"There are {spots} spots left. Reduce the amount.") { }
}