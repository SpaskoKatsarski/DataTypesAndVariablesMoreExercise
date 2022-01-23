using System;

namespace T05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string word = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                
                char newCharacter = (char)(currentChar + key);

                word += newCharacter;
            }
            Console.WriteLine(word);
        }
    }
}

