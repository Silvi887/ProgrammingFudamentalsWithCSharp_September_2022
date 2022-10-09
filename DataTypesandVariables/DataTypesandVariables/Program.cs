using System;

namespace DataTypesandVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());

            int FourNumber = int.Parse(Console.ReadLine());

            ///
            int firstResult = FirstNumber + SecondNumber;
            int secondResult = firstResult / ThirdNumber;
            int thirdResult = secondResult * FourNumber;

            Console.WriteLine(thirdResult);


        }
    }
}
