using System;
using System.Linq;

namespace T02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long maxValue = 0;
                int maxIndex = 0;
                long sumOfDigits = 0;

                long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
                maxValue = arr.Max();
                maxIndex = arr.ToList().IndexOf(maxValue);

                while (maxValue != 0)
                {
                    sumOfDigits += maxValue % 10;
                    maxValue /= 10;
                }
                Console.WriteLine(sumOfDigits);
            }
        }
    }
}
