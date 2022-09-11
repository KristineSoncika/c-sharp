namespace VendingMachine.Exceptions;

public class ValidCoinsListCannotBeEmptyException : Exception
{
    public ValidCoinsListCannotBeEmptyException() :
        base("The list cannot be empty.") { }
}