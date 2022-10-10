using System;

namespace MethodsEx
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            SmallestElement(num1, num2, num3);

        }
        static void SmallestElement(int a, int b, int c)
        {

            int[] Arr = new int[3];

            Arr[0] = a;
            Arr[1] = b;
            Arr[2] = c;

            Array.Sort(Arr);
            Console.WriteLine(Arr[0]);

        }
    }
}
