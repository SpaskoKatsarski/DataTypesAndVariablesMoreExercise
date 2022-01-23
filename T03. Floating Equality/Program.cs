using System;

namespace T03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal EPS = 0.000001m;

            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());

            decimal difference = Math.Abs((decimal)firstNumber - (decimal)secondNumber);

            if (difference < EPS)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
