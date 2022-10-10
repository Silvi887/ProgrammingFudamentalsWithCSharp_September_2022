using System;

namespace _7NNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int i = 1; i <= n; i++)//rows
            {
                for (int j = 1; j <= n; j++)//columns
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();

            }

        }
    }
}
