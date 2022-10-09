using System;

namespace _3Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumberPeople = int.Parse(Console.ReadLine());
            int pcapacity = int.Parse(Console.ReadLine());


            int courses =(int)Math.Ceiling((double)NumberPeople/pcapacity);

            char c = (char)'a';
            Console.WriteLine(c);
        
        }
    }
}
