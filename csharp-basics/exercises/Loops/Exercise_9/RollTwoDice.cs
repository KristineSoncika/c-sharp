using System;

namespace Exercise_9
{
    public class RollTwoDice
    {
        public void Game(int sum)
        {
            Random randomNumber = new();
            int calcSum = 0;

            while(calcSum != sum)
            {
                int num1 = randomNumber.Next(1, 7);
                int num2 = randomNumber.Next(1, 7);
                calcSum = num1 + num2;
                Console.WriteLine($"{num1} and {num2} = {calcSum}");
            }
        }
    }
}