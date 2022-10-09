using System;
using System.Linq;
using System.Numerics;

namespace _02FromLefttoThe_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string FirstStr = Console.ReadLine();

                string[] Arr = FirstStr.Split(' ').ToArray();


                BigInteger firstNum = BigInteger.Parse(Arr[0].ToString());
                BigInteger secondNum = BigInteger.Parse(Arr[1].ToString());
                int sum = 0;
                if (firstNum >= secondNum)
                {
                    for (BigInteger m = BigInteger.Abs(firstNum); m > 0; m = m / 10)
                    {
                        sum = sum + (int)(m % 10);
                    }
                    Console.WriteLine(sum);

                }

                else
                {


                    for (BigInteger m = BigInteger.Abs(secondNum); m > 0; m = m / 10)
                    {
                        sum = sum + (int)(m % 10);
                    }
                    Console.WriteLine(sum);
                }

            }//
        }
    }
}
