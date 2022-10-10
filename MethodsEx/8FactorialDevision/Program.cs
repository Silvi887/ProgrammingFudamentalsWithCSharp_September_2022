using System;

namespace _8FactorialDevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber>0)
            {
                FactorialDivision(firstNumber, secondNumber);
            }
          
        }

        static void FactorialDivision(int firstNumber, int secondNumber)
        {


            int FactorialFirstNumber = 1;
            int FactorialSecondNumber = 1;

            for (int i = 1; i <= firstNumber; i++)
            {
                FactorialFirstNumber *= i;
            }

            for (int j = 1; j <= secondNumber; j++)
            {
                FactorialSecondNumber *= j;
            }

            double Reasult = (double)FactorialFirstNumber / FactorialSecondNumber;


            Console.WriteLine($"{Reasult:F2}");

        }
    }
}
