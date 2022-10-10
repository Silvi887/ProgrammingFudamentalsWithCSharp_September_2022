using System;
using System.Linq;

namespace _2VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var vowelsCount=getVowelsCount(text);

           Console.WriteLine(vowelsCount);
            // int Method
        }

        static int getVowelsCount (string text)
        {

            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };

            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
        //static void VowelsCount(string word)
        //{
        //    int cvol = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        char a = (char)word[i];
        //        if (a == 'a' || a == 'o' || a == 'e' || a == 'i' || a == 'u' || a == 'U'
        //            || a == 'A' || a == 'O' || a == 'E' || a == 'I')
        //        {
        //            cvol++;
        //        }
        //    }
        //    Console.WriteLine(cvol);
        //}
    }
}
