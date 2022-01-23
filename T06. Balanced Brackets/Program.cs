using System;

namespace T06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isBalanced = true;

            string currentBracket = String.Empty;
            string previousBracket = String.Empty;

            // 8

            // (
            // 5 + 10
            // )
            // *2 +
            // (
            // 5
            // )
            // -12

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (i == 1)
                {
                    if (input != "(")
                    {
                        isBalanced = false;
                    }
                    currentBracket = input;
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        if (previousBracket == currentBracket)
                        {
                            isBalanced = false;
                        }
                        previousBracket = currentBracket;
                        currentBracket = input;
                    }
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

            // SECOND OPTION:

            //long n = long.Parse(Console.ReadLine());
            //long openCount = 0;
            //long closeCount = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    string input = Console.ReadLine();
            //    if (input == "(")
            //    {
            //        openCount++;

            //    }
            //    else if (input == ")")
            //    {
            //        closeCount++;
            //        if (openCount - closeCount != 0)
            //        {
            //            Console.WriteLine("UNBALANCED");
            //            return;
            //        }
            //    }
            //}
            //if (openCount == closeCount)
            //{
            //    Console.WriteLine("BALANCED");
            //}
            //else
            //{
            //    Console.WriteLine("UNBALANCED");
            //}
        }
    }
}
