using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enterText = Console.ReadLine();

            string Patern1 = @"(\@|\#)(?<firstword>[A-Za-z]{3,})\1{2}(?<secondword>[A-Za-z]{3,})\1";
            Dictionary<string, string> ListMirrorWords = new Dictionary<string, string>();
            Regex regex1 = new Regex(Patern1);

            MatchCollection matches = regex1.Matches(enterText);
           
               

                foreach (Match item in matches)
                {
                    String WORD1 = item.Groups["firstword"].ToString();
                    String WORD2 = item.Groups["secondword"].ToString();

                    string reverceword2 = "";
                    for (int i = WORD2.Length-1; i >= 0; i--)
                    {
                        reverceword2 +=(char)WORD2[i];
                    }

                    if (WORD1 == reverceword2)
                    {

                        ListMirrorWords.Add(WORD1,WORD2);

                    }
                }
        

          if (matches.Count >0)
            {
                   Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine($"No word pairs found!");
            }

            if (ListMirrorWords.Count >0)
            {
                Console.WriteLine($"The mirror words are:");

                
                    Console.WriteLine(String.Join(", ", ListMirrorWords.Select(x => x.Key +" <=> " +x.Value)));
                


            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
