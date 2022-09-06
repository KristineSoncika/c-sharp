namespace Hierarchy.Exceptions;

public class InvalidWeightException : Exception
{
    public InvalidWeightException() : 
        base("Weight must be greater than 0.") { }
}