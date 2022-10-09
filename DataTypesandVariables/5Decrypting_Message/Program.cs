using System;

namespace _5Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)

        {
            int key = int.Parse(Console.ReadLine());
            int n= int.Parse(Console.ReadLine());
            string printText = "";
            for (int i = 1; i <= n; i++)
            {
                char a = char.Parse(Console.ReadLine());
                int allkey = key + a;
                char newletter = (char)allkey;
                printText += newletter;
            }
            Console.WriteLine(printText);
        }
    }
}
