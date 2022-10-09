using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());

            double maxVolume = int.MinValue;
            string maxModel = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius=double.Parse(Console.ReadLine());
                int height=int.Parse(Console.ReadLine());

                double V = Math.PI * Math.Pow(radius, 2) * height;
                if (V>maxVolume)
                {
                    maxVolume = V;
                    maxModel = model;
                }
            
            }

            Console.WriteLine($"{maxModel}");
        }
    }
}
