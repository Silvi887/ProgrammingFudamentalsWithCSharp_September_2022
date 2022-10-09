using System;

namespace _3FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());

            double maxdifference = 0.000001;

            double difference = Math.Abs(a - b);
            if (difference < maxdifference)
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
