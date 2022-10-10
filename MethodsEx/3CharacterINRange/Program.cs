using System;

namespace _3CharacterINRange
{
    class Program
    {
        static void Main(string[] args)
        {

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharacterInRange(a, b);



        }

        static void CharacterInRange(char a, char b)
        {
            int a1 = (int)a;
            int b1 = (int)b;

            if (b1<a1)
            {
                int c = a1;
                a1 = b1;
                b1 = c;
            }
            for (int i = a1 + 1; i < b1; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
        }
    }
}
