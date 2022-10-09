using System;

namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Age= int.Parse(Console.ReadLine());

           if(Age >=0 && Age <= 2)
            {

                Console.WriteLine("baby");
            }

        
            else if (Age >= 3 && Age <= 13)
            {
                Console.WriteLine("teenager");
            }
            else if (Age >= 14 && Age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (Age >= 20 && Age <= 65)
            {
                Console.WriteLine("adult");
            }
           else if(Age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
