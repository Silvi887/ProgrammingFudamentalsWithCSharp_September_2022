using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger V = 0;// (snowballSnow / snowballTime) ^ snowballQuality;

            //maxValue is used for comparison and finding the max value!!!
            BigInteger MaxV = BigInteger.MinusOne;

            int snowballSnowM =0;
            int snowballTimeM = 0;
            int snowballQualityM = 0;


            for (int i = 1; i <= N; i++)
            {
                //1 iteration -> 1 snowball
                //For each snowball -> 3 lines
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                 V = BigInteger.Pow((snowballSnow / snowballTime) ,snowballQuality);
                if (MaxV <V)
                {
                    MaxV = V;
                    snowballSnowM = snowballSnow;
                    snowballTimeM = snowballTime;
                    snowballQualityM = snowballQuality;
                }


            }

            Console.WriteLine($"{snowballSnowM} : {snowballTimeM} = {MaxV} ({snowballQualityM})");
        }
    }
}
