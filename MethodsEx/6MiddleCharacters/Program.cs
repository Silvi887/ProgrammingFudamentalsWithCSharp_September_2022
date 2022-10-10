using System;

namespace _6MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string entered = Console.ReadLine();

            int n = entered.Length / 2;

           
            char r;
            char r1;
            if (entered.Length % 2 == 0)//even
            {
               
                 r = (char)entered[n-1];
                r1 = (char)entered[(n - 1) + 1];



                Console.WriteLine($"{r}{r1}");
             
            }
            else                  //odd
            {
                r = (char)entered[n];

                Console.WriteLine(r);
            }
        }
    }
}
