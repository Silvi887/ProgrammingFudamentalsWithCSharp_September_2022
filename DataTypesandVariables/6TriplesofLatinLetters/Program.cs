using System;

namespace _6TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int res1 = 'a';
            int res = 'a' + number;
            for (char i = 'a'; i < 'a' + number; i++)
            {

                for (char k = 'a'; k < 'a' + number; k++)
                {


                    for (char l = 'a'; l < 'a' + number; l++)
                    {


                        Console.WriteLine($"{i}{k}{l}");
                    }

                }

            }
        }
    }
}
