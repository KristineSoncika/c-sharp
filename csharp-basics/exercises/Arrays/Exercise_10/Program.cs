using System;

namespace Exercise_10
{
    class Program
    {
        private static void Main()
        {
            double[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            double[] arr2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            double[] arr3 = { 91, -4, 80, -73, -28 };
            double[] arr4 = { };
            CountPosSumNeg(arr1);
            CountPosSumNeg(arr2);
            CountPosSumNeg(arr3);
            CountPosSumNeg(arr4);
        }

        static double[] CountPosSumNeg(double[] arr)
        {
            if (arr.Length == 0)
            {
                return arr;
            }

            double[] result = new double[2];
            double count = 0;
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                    result[0] = count;
                }
                else
                {
                    sum += arr[i];
                    result[1] = (int)sum;
                }
            }

            Console.WriteLine(String.Join(", ", result));
            return result;
        }
    }
}