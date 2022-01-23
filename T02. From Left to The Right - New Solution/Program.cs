using System;
using System.Linq;

namespace T02._From_Left_to_The_Right___New_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            bool isFirstNum = true;
            string firstNumAsString = String.Empty;
            string secondNumAsString = String.Empty;

            for (int i = 0; i < int.Parse(numbers); i++)
            {
                firstNumAsString = Console.ReadLine();
                secondNumAsString = Console.ReadLine();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (isFirstNum && numbers[i] != ' ')
                    {
                        firstNumAsString += numbers[i];
                    }
                    else if (!isFirstNum && numbers[i] != ' ')
                    {
                        secondNumAsString += numbers[i];
                    }
                    else if (numbers[i] == ' ')
                    {
                        isFirstNum = false;
                    }
                }
            }

            int firstNumber = int.Parse(firstNumAsString);
            int secondNumber = int.Parse(secondNumAsString);

            int sum = 0;

            if (firstNumber > secondNumber)
            {
                for (int i = 0; i < firstNumAsString.Length; i++)
                {
                    sum += firstNumber % 10;
                    firstNumber /= 10;
                }
            }
            else
            {
                for (int i = 0; i < secondNumAsString.Length; i++)
                {
                    sum += secondNumber % 10;
                    secondNumber /= 10;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
