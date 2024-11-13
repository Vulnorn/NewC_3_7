using System;

namespace NewC_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineWithText = "You win some";

            string[] words = lineWithText.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine($"{word}");
            }

            Console.ReadKey();
        }
    }
}