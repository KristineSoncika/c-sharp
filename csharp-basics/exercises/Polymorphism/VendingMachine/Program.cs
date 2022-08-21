using System;

namespace VendingMachine
{
    internal class Program
    {
        private static readonly VendingMachine vendingMachine = new("WhoKnows", 35);

        static void Main()
        {
            Console.WriteLine(vendingMachine.Amount);
            vendingMachine.InsertCoin(new Money(0, 50));
            Console.WriteLine(vendingMachine.Amount);

            vendingMachine.InsertCoin(new Money(0, 20));
            Console.WriteLine(vendingMachine.Amount);

            vendingMachine.InsertCoin(new Money(0, 50));
            Console.WriteLine(vendingMachine.Amount);

            vendingMachine.InsertCoin(new Money(2, 00));
            Console.WriteLine(vendingMachine.Amount);

            vendingMachine.InsertCoin(new Money(2, 50));
            Console.WriteLine(vendingMachine.Amount);

            vendingMachine.GetAllProducts();
            vendingMachine.AddProduct("Snickers", new Money(0, 70), 10);
            vendingMachine.AddProduct("Mars", new Money(0, 60), 12);
            vendingMachine.AddProduct("Mars", new Money(0, 70), 12);
            vendingMachine.AddProduct("Twix", new Money(0, 80), 14);
            Console.WriteLine(vendingMachine.EmptySpots);
            vendingMachine.GetAllProducts();

            vendingMachine.UpdateProduct(2, "Mars", new Money(0, 70), 12);
            vendingMachine.UpdateProduct(1, "Snicky", new Money(0, 90), 0);
            vendingMachine.AddProduct("Twix", new Money(1, 80), 5);
            Console.WriteLine(vendingMachine.EmptySpots);
            vendingMachine.GetAllProducts();

            vendingMachine.BuyProduct(2);
            Console.WriteLine(vendingMachine.EmptySpots);
            vendingMachine.GetAllProducts();

            vendingMachine.BuyProduct(4);
            Console.WriteLine(vendingMachine.EmptySpots);
            vendingMachine.GetAllProducts();

            vendingMachine.InsertCoin(new Money(2, 00));
            Console.WriteLine(vendingMachine.Amount);

            vendingMachine.BuyProduct(1);
            vendingMachine.BuyProduct(2);
        }
    }
}