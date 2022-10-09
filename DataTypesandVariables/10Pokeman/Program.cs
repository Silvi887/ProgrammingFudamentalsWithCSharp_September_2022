using System;

namespace _10Pokeman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            double halfOriginalN = N / 2;
            int counttargets = 0;

            //Calc
            while (N >= M)
            {

                N -= M;
                counttargets++;
              
                if (N == (int)halfOriginalN && Y != 0)
                {// polovinata ot na4 st.
                    N = N / Y; //da se delqt delitelq !=0
                }

            }
            Console.WriteLine(N);
            Console.WriteLine(counttargets);
        }
    }
}
