namespace Hierarchy.Exceptions;

public class InvalidRegionException : Exception
{
    public InvalidRegionException() : 
        base("Region cannot be null or empty.") { }
}