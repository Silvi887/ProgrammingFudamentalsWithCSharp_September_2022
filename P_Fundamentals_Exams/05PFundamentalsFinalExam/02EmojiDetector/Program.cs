using System;

namespace _02EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Message = Console.ReadLine();


            int CoolThreshold = 1;


            foreach (char ch in Message)
            {
                if (char.IsDigit(ch))
                {
                    char a = (char)ch;
                    int a1 = (int)a;


                    int num = (int)ch - 48;
                    CoolThreshold *= num;
                }

            }

            Console.WriteLine($"Cool threshold: {CoolThreshold}");




            string patern = @"(\:\:|\*\*)([A-Z][a-z]{2,})\1";

            Regex regex = new Regex(patern);
            // Match match = regex.Match(Message);
            bool isValidEmogy = regex.IsMatch(Message);
            if (isValidEmogy)
            {
                MatchCollection matches = regex.Matches(Message);

                int countEmogies = matches.Count;
                Console.WriteLine($"{countEmogies} emojis found in the text. The cool ones are:");
                foreach (Match item in matches)
                {
                    string Emogy = item.Value;
                    int coolness = 0;
                    foreach (char ch in Emogy)
                    {
                        if (char.IsLetter(ch))
                        {
                            int num = (int)ch;
                            coolness += num;
                        }


                    }
                    if (coolness > CoolThreshold)
                    {
                        Console.WriteLine(item.Value);
                    }




                }

            }
        }
    }
}
