using System;

namespace Exercise_6
{
    class Program
    {
        static void Main()
        {
            CozaLozaWoza();
        }

        static void CozaLozaWoza()
        {
            string wordPrinted = "";
            for(int i = 1; i <= 110; i++)
            {
                if (!(i % 3 == 0) && !(i % 5 == 0) && !(i % 7 == 0))
                {
                    Console.Write($"{i} ");
                }
                if (i % 3 == 0)
                {
                    wordPrinted += "Coza";                    
                } 
                if(i % 5 == 0)
                {
                    wordPrinted += "Loza";                    
                }
                if(i % 7 == 0)
                {
                    wordPrinted += "Woza";                    
                }
                
                Console.Write($"{wordPrinted} ");
                wordPrinted = "";

                if (i % 11 == 0)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}