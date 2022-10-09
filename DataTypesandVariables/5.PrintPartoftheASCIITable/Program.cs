using System;

namespace _5.PrintPartoftheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {

            int startLetter = int.Parse(Console.ReadLine());
            int endLetter = int.Parse(Console.ReadLine());
            //Console.WriteLine((char)startLetter);

            string alltext = "";
            for (int i = startLetter; i <= endLetter; i++)
            {

                char let = (char)i;
                if (alltext == "")
                {
                    alltext += let;

                }
                else
                {
                    alltext += " "+ let;
                }


            }

            Console.WriteLine(alltext);
        }
    }
}
