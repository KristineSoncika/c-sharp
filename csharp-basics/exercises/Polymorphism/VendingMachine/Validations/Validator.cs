using System.ComponentModel;
using VendingMachine.Exceptions;

namespace VendingMachine.Validations;

public static class Validator
{
    public static void ValidateEuros(int euros) 
    {
        if (euros < 0)
        {
            throw new InvalidEurosException(euros);
        }
    }

    public static void ValidateCents(int cents)
    {
        if (cents is < 0 or >= 100)
        {
            throw new InvalidCentsException(cents);
        }
    }

    public static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new InvalidNameException();
        }
    }

    public static void ValidateAmount(int amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException(amount);
        }
    }

    public static void ValidateProductNumber(int productNumber, List<Product> products)
    {
        if (productNumber < 1 || productNumber > products.Count)
        {
            throw new InvalidProductNumberException(productNumber);
            
        }
    }

    public static void ValidateCoinsList(List<string> coinList)
    {
        if (coinList.Count < 1)
        {
            throw new ValidCoinsListCannotBeEmptyException();
        }
    }
}