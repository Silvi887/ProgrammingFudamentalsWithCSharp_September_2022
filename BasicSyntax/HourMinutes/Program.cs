using System;

namespace HourMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour= int.Parse(Console.ReadLine());
            int min= int.Parse(Console.ReadLine())+30;


            Console.WriteLine($"{hour}:{min}");


            //2:40 +
            //40 +30=70

            //70-60=10
            if(min > 59)
            {
                hour += 1;
                min -= 60;

            }


            //23:59  +30
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine("{0}:{1:D2}", hour, min);

        }
    }
}
