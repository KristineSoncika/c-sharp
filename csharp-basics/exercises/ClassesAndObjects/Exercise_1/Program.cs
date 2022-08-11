using System;

namespace Exercise_1
{
    class Program
    {
        static void Main()
        {
            Product product1 = new("Logitech mouse", 70.00, 14);
            Product product2 = new("iPhone 5s", 999.99, 3);
            Product product3 = new("Epson EB-U05", 440.46, 1);

            product1.PrintProduct();
            product2.PrintProduct();
            product3.PrintProduct();

            product1.ChangeAmount(15);
            product1.PrintProduct();

            product3.ChangePrice(556.34);
            product3.PrintProduct();
        }
    }
}