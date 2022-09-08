namespace VendingMachine.Exceptions;

public class InvalidEurosException : Exception
{
    public InvalidEurosException(int euros) :
        base($"Euros cannot be negative: {euros}.") { }
}