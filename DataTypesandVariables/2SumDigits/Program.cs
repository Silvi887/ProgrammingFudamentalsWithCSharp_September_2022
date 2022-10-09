using System;

namespace _2SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            string txtNum = Number.ToString();


            int sumdigits = 0;
            for (int i = 0; i <= txtNum.Length-1; i++)
            {
                sumdigits += int.Parse(txtNum[i].ToString());
            }

            Console.WriteLine(sumdigits);
        }
    }
}
