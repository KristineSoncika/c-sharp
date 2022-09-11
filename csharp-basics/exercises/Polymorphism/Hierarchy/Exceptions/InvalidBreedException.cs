namespace Hierarchy.Exceptions;

public class InvalidBreedException : Exception
{
    public InvalidBreedException() : 
        base("Breed cannot be null or empty.") { }
}