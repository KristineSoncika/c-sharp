using System;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private string _manufacturer;
        private int _capacity;
        private int _emptySpots;
        private List<string> _validCoins = new() { "0.10", "0.20", "0.50", "1.00", "2.00" };

        private List<Product> _products { get; set; }
        public Product[] Products
        {
            get { return _products.ToArray(); }
            set { }
        }

        public string Manufacturer => _manufacturer;
        public string ValidCoins => String.Join(" | ", _validCoins);
        public int Capacity => _capacity;
        public int EmptySpots => _emptySpots;
        public bool HasProducts => _products.Count > 0;
        public Money Amount { get; private set; }

        public VendingMachine(string manufacturer, int capacity)
        {
            _manufacturer = manufacturer;
            _products = new();
            _capacity = capacity;
            _emptySpots = capacity;
        }

        private Money SumInsertedCoins(Money amount)
        {
            var euros = Amount.Euros + amount.Euros;
            var cents = Amount.Cents + amount.Cents;
            if (cents >= 100)
            {
                euros++;
                cents = cents % 100;
            }

            return new Money(euros, cents);
        }

        private Money CalculateChange(Money amount)
        {
            var euros = Amount.Euros - amount.Euros;
            var cents = Amount.Cents - amount.Cents;
            if (cents < 0)
            {
                euros--;
                cents = 100 + cents;
            }

            return new Money(euros, cents);
        }

        public Money InsertCoin(Money amount)
        {
            if (!_validCoins.Contains(amount.ToString()))
            {
                Console.WriteLine($"Accepted coins are: {ValidCoins}. Try again!");
                return Amount;
            }

            Amount = SumInsertedCoins(amount);
            return Amount;
        }

        public bool BuyProduct(int productNumber)
        {
            if (productNumber < 1 || productNumber > _products.Count)
            {
                Console.WriteLine($"Invalid product number. Valid numbers are between 1 and {_products.Count}");
                return false;
            }
            else if (_products[productNumber - 1].Available < 1)
            {
                Console.WriteLine("This product is not available. Try another one.");
                return false;
            }
            else if (_products[productNumber - 1].Price.GetValue() > Amount.GetValue())
            {
                Console.WriteLine("Your funds are not sufficient. Please insert more coins.");
                return false;
            }
            else
            {
                _emptySpots++;
                Product boughtProduct = _products[productNumber - 1];
                boughtProduct.Available--;
                _products[productNumber - 1] = boughtProduct;
                Amount = CalculateChange(boughtProduct.Price);
                ReturnMoney();
                Console.WriteLine("Thank you! See you next time!");
                return true;
            }
        }

        public Money ReturnMoney()
        {
            if (Amount.GetValue() == 0)
            {
                Console.WriteLine("No change!");
                return Amount;
            }
            else
            {
                Console.WriteLine($"Here is your change: {Amount}");
                Amount = new Money();
                return Amount;
            }
        }

        public bool AddProduct(string name, Money price, int amount)
        {
            if(_products.Exists(p => p.Name == name))
            {
                Console.WriteLine("The product has already been added. Please update the product instead!");
                return false;
            }
            else if (_emptySpots - amount <= 0)
            {
                Console.WriteLine($"There are only {_emptySpots} left. Reduce the amount or try again later.");
                return false;
            }
            else
            {
                _products.Add(new Product(name, price, amount));
                _emptySpots -= amount;
                return true;
            }
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if(productNumber < 1 && productNumber > _products.Count)
            {
                Console.WriteLine($"Invalid product number. Valid numbers are between 1 and {_products.Count}");
                return false;
            }
            else
            {
                Product productToUpdate = _products[productNumber - 1];
                productToUpdate.Name = name;
                productToUpdate.Price = (Money)price;
                productToUpdate.Available = amount;
                _products[productNumber - 1] = productToUpdate;
                return true;
            }
        }

        public void GetAllProducts()
        {
            if (HasProducts)
            {
                Console.WriteLine(String.Join("\n", _products));
                
            }
            else
            {
                Console.WriteLine("The machine is empty!");
            }
        }
    }
}