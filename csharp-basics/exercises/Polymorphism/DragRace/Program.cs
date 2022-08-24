using System;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main()
        {
            List<Car> cars = new() { new Audi(8), new Bmw(9), new Lexus(15), new Toyota(8), new Volkawagen(9), new Tesla(10) };

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 3 && car is IBoost boosted)
                    {
                        boosted.UseNitrousOxideEngine();
                    }
                    else
                    {
                        car.SpeedUp();
                    }
                }
            }

            var fastestCar = cars.OrderByDescending(car => car.CurrentSpeed).First();
            Console.WriteLine($" {fastestCar} is the fastest car with the speed of {fastestCar.CurrentSpeed} km/h");
        }
    }
}