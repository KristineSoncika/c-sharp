namespace VendingMachine.Exceptions;

public class ProductAlreadyAddedException : Exception
{
    public ProductAlreadyAddedException(string product) :
        base($"This product has already been added: {product}. Update the product instead!") { }
}