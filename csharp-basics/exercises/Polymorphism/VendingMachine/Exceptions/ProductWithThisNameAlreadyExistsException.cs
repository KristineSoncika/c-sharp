namespace VendingMachine.Exceptions;

public class ProductWithThisNameAlreadyExistsException : Exception
{
    public ProductWithThisNameAlreadyExistsException(string name) :
        base($"Product with name {name} already exists. Update existing product instead.") { }
}