using System;

namespace _7waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double tankcapacity = 255.0;

            double enteredcapacity = 0;

            for (int i = 1; i <= n; i++)
            {
                double waterquantity = double.Parse(Console.ReadLine());


                enteredcapacity += waterquantity;
                
                 if((enteredcapacity > tankcapacity)|| (waterquantity > tankcapacity))
                {
                    Console.WriteLine("Insufficient capacity!");
                    enteredcapacity -= waterquantity;
                }
               
            }

            Console.WriteLine(enteredcapacity);
        }
    }
}
