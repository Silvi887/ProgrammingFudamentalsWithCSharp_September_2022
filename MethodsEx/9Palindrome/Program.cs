using System;

namespace _9Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entered = Console.ReadLine();
            PrintPalindrome (entered);
        }

        static void PrintPalindrome(string entered)
        {
            string reversed = string.Empty;

            while (entered !="END")
            {
                for (int i = entered.Length-1; i >=0; i--)
                {
                    reversed += entered[i];
                }

                if (entered != reversed)
                {
                    Console.WriteLine(false);
                }
                else
                {
                    Console.WriteLine(true);
                }
                entered = Console.ReadLine();
                reversed = String.Empty;
            }

           

        }
    }
}
