using VendingMachine;

namespace VendingMachineUI;

internal static class Program
{
    private static readonly VendingMachine.VendingMachine VendingMachine = new("WhoKnows", 35, new List<string> { "0.10", "0.20", "0.50", "1.00", "2.00" });

    private static void Main()
    {
        VendingMachine.AddProduct("Mars", new Money(0, 70), 5);
        VendingMachine.AddProduct("Snickers", new Money(0, 50), 6);
        VendingMachine.AddProduct("Bounty", new Money(0, 60), 7);

        while(true)
        {
            Console.WriteLine(new string('_', 60));
            Console.WriteLine($"\nThis is W3-45-20B produced by {VendingMachine.Manufacturer}. What would you like to do?\n");
            Console.WriteLine("Type 0 to exit");
            Console.WriteLine("Type 1 to check the available products");
            Console.WriteLine("Type 2 to insert coins");
            Console.WriteLine("Type 3 to receive change");
            Console.WriteLine("Type 4 to add a product (maintenance)");
            Console.WriteLine("Type 5 to update a product (maintenance)");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    return;
                case "1":
                    ShowProducts();
                    break;
                case "2":
                    InsertCoins();
                    break;
                case "3":
                    ReturnChange();
                    break;
                case "4":
                    AddProduct();
                    break;
                case "5":
                    UpdateProduct();
                    break;
            }
        }
    }
    
    private static void ShowProducts()
    {
        if (VendingMachine.HasProducts)
        {
            var num = 1;
            Console.WriteLine("\nOur product list:\n");
            Console.WriteLine($"{"N",3} | {"Name",9} | {"Price",5} | {"Amount",3}");
            Console.WriteLine($"{new string('-',3), 4}|{new string('-',11), 8}|{new string('-',7), 4}|{new string('-',7), 2} ");

            foreach (var product in VendingMachine.Products)
            {
                Console.WriteLine($"{num,3} | {product.Name,9} | {product.Price,5} | {product.Available,3}");
                num++;
            }
        }
        else
        {
            Console.WriteLine("The machine is empty!");
        }
    }

    private static void AddProduct()
    {
        Console.WriteLine("\nEnter product name:");
        var name = Console.ReadLine();

        Console.WriteLine("Enter price in the following format (euros cents): 0 00");
        var coins = Console.ReadLine().Split();
        var euros = int.Parse(coins[0]);
        var cents = int.Parse(coins[1]);

        Console.WriteLine("Enter amount:");
        var amount = int.Parse(Console.ReadLine());

        try
        {
            VendingMachine.AddProduct(name, new Money(euros, cents), amount);
            Console.WriteLine($"\nProduct added -> {VendingMachine.Products[^1]}");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static void UpdateProduct()
    {
        Console.WriteLine($"\nEnter product number 1 - {VendingMachine.Products.Length}");
        var prodNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter product name:");
        var name = Console.ReadLine();

        Console.WriteLine("Enter price in the following format (euros cents): 0 00");
        var coins = Console.ReadLine().Split();
        var euros = int.Parse(coins[0]);
        var cents = int.Parse(coins[1]);

        Console.WriteLine("Enter amount:");
        var amount = int.Parse(Console.ReadLine());

        try
        {
            VendingMachine.UpdateProduct(prodNum, name, new Money(euros, cents), amount);
            Console.WriteLine($"\nProduct updated -> {VendingMachine.Products.FirstOrDefault(product => product.Name == name)}");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static void InsertCoins()
    {
        Console.WriteLine($"\nValid coins are: 0.10, 0.20, 0.50, 1.00, 2.00");
        Console.WriteLine("Insert coins in the following format (euros cents): 0 00");
        
        try
        {
            var coins = Console.ReadLine().Split();
            var euros = int.Parse(coins[0]);
            var cents = int.Parse(coins[1]);
            VendingMachine.InsertCoin(new Money(euros, cents));
            Console.Write($"Your amount is {VendingMachine.Amount}\n");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine("Try again!");
        }
    }

    private static void ReturnChange()
    {
        try
        {
            Console.WriteLine($"\nDon't forget to collect your change: {VendingMachine.ReturnMoney()} \nSee you next time!");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine("See you next time!");
        }
    }
}