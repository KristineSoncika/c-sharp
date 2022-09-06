namespace Hierarchy.Exceptions;

public class InvalidNameException : Exception
{
    public InvalidNameException() : 
        base("Name cannot be null or empty.") { }
}