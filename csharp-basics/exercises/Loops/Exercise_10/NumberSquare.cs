using System;

namespace Exercise_10
{
    public class NumberSquare
    {
        public void GenerateSquare(int min, int max)
        {
            List<int> numArr = new();

            for (int i = min; i <= max; i++)
            {
                numArr.Add(i);
            }

            int index = 0;

            for (int i = 0; i < numArr.Count; i++)
            {                
                for (int j = index; j < numArr.Count + index; j++)
                {
                    Console.Write(numArr[j % numArr.Count]);                    
                }

                Console.Write(Environment.NewLine);
                index++;
            }
        }
    }
}