using System;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            for (int num = 1; num <= Number; num++)
            {
                bool Isdivisavble = IsDivisableEigth(num);
                bool IsholdingOdd = IsholdingOneOdd(num);

                if (Isdivisavble== true && IsholdingOdd== true)
                {
                    Console.WriteLine(num);
                }
            }

        }

        static bool IsDivisableEigth(int Number)
        {
           
            int LastDigit = Number;
            int sum = 0;
            while (Number != 0)
            {
                LastDigit = Number % 10;

                sum += LastDigit;
                Number = Number / 10;

            }

            if (sum % 8 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsholdingOneOdd(int Number)
        {

            int LastDigit = Number;
            int countcontodd = 0;
            while (Number != 0)
            {
                LastDigit = Number % 10;

                
                if (LastDigit % 2==1)
                {
                    countcontodd++;
                   // return true;
                }
                Number = Number / 10;

                
            }
          //  return false;
            if (countcontodd > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }



        }
}
