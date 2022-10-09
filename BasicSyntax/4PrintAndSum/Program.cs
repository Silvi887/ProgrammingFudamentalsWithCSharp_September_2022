using System;

namespace _4PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int startNumber= int.Parse(Console.ReadLine());
            int endNumber= int.Parse(Console.ReadLine());

            int sumNumbers = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                sumNumbers += i;
                Console.Write(i+" ");
            }
            Console.WriteLine();
           Console.WriteLine("Sum: "+sumNumbers);
        }
    }
}
