using System;
using System.Globalization;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.m.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
              "dd.m.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday &&
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            Console.WriteLine(holidaysCount);


            //int number =int.Parse(Console.ReadLine());
            //int startNumber=int.Parse(Console.ReadLine());

            //if(startNumber <= 10)
            //{
            //    for(int i = startNumber; i <=10 ; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //do
            //{
            //    Console.WriteLine("Test");
            //}
            //while (true);

        }
    }
}
