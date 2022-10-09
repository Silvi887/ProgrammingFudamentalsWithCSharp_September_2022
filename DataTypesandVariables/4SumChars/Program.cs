using System;

namespace _4SumChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sumletters = 0;

            for (int i = 1; i <= n; i++)
            {
                char letter =char.Parse( Console.ReadLine());
                int numlet = (int)letter;
                sumletters += numlet;
            }

            Console.WriteLine($"The sum equals: {sumletters}");
        }
    }
}
