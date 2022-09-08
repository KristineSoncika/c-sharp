namespace VendingMachine.Exceptions;

public class NoChangeException : Exception
{
    public NoChangeException() :
        base("There is no change to return.") { }
}