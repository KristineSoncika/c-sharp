namespace Hierarchy.Exceptions;

public class InvalidTypeException : Exception
{
    public InvalidTypeException() : 
        base("Type cannot be null or empty.") { }
}