using System;

namespace Exercise_11
{
    class Program
    {
        static void Main()
        {
            MoranNumbers(132);
            MoranNumbers(133);
            MoranNumbers(134);
        }

        static void MoranNumbers(int num)
        {
            string numStr = num.ToString();
            double numSum = 0;

            for(int i = 0; i < numStr.Length; i++)
            {
                numSum += Char.GetNumericValue(numStr[i]);
            }

            bool harshadNum = (num / numSum) % 1 == 0;
            bool moranNum = harshadNum && IsPrime(num / numSum);

            if (moranNum)
            {
                Console.WriteLine("M");
            }
            else if (harshadNum)
            {
                Console.WriteLine("H");
            }
            else
            {
                Console.WriteLine("Neither");
            }            
        }

        static bool IsPrime(double num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num == 2 || num == 3)
            {
                return true;
            }

            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }                
            }

            return true;
        }
    }
}