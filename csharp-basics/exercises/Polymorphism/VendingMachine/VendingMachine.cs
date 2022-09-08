using VendingMachine.Exceptions;
using VendingMachine.Interfaces;
using VendingMachine.Validations;

namespace VendingMachine;

public class VendingMachine : IVendingMachine
{
    private readonly List<Product> _products;
    private readonly List<string> _validCoins;
    private int _emptySpots;
    public string Manufacturer { get; }
    public bool HasProducts => _products.Count > 0;
    public Money Amount { get; private set; }
    public Product[] Products { get => _products.ToArray(); set { } }
    
    public VendingMachine(string manufacturer, int capacity, List<string> validCoins)
    {
        Validator.ValidateName(manufacturer);
        Validator.ValidateAmount(capacity);
        Validator.ValidateCoinsList(validCoins);
        
        Manufacturer = manufacturer;
        _validCoins = validCoins;
        _products = new List<Product>();
        _emptySpots = capacity;
    }

    private Money SumInsertedCoins(Money amount)
    {
        var euros = Amount.Euros + amount.Euros;
        var cents = Amount.Cents + amount.Cents;
        
        if (cents >= 100)
        {
            euros++;
            cents %= 100;
        }

        return new Money(euros, cents);
    }

    public Money InsertCoin(Money amount)
    {
        if (!_validCoins.Contains(amount.ToString()))
        {
            throw new InvalidCoinException(amount.ToString());
        }

        Amount = SumInsertedCoins(amount);
        return Amount;
    }

    public Money ReturnMoney()
    {
        var change = Amount;
        
        if (change.GetValue() == 0)
        {
            throw new NoChangeException();
        }
        
        Amount = new Money();
        return change;
    }

    public bool AddProduct(string name, Money price, int amount)
    {
        Validator.ValidateName(name);
        Validator.ValidateAmount(amount);
        
        if(_products.Exists(product => product.Name == name))
        {
            throw new ProductAlreadyAddedException(name);
        } 
        
        if (_emptySpots - amount < 0)
        {
            throw new NotEnoughEmptySpotsException(_emptySpots);
        }

        _products.Add(new Product(name, price, amount));
        _emptySpots -= amount;
        return true;
    }

    public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
    {
        if (!HasProducts)
        {
            throw new MachineIsEmptyException();
        }
        
        Validator.ValidateName(name);
        Validator.ValidateAmount(amount);
        Validator.ValidateProductNumber(productNumber, _products);

        if (_products.Exists(product => product.Name == name))
        {
            throw new ProductWithThisNameAlreadyExistsException(name);
        }
        
        var amountDiff = Math.Abs(_products[productNumber - 1].Available - amount);
        
        if (amount > _products[productNumber - 1].Available && amountDiff > _emptySpots)
        {
            throw new NotEnoughEmptySpotsException(_emptySpots);
        }

        var productToUpdate = _products[productNumber - 1];
        productToUpdate.Name = name;
        productToUpdate.Price = (Money)price;
        productToUpdate.Available = amount;
        _products[productNumber - 1] = productToUpdate;

        _emptySpots = _products[productNumber - 1].Available > amount ? _emptySpots - amountDiff : _emptySpots + amountDiff;

        return true;
    }
}