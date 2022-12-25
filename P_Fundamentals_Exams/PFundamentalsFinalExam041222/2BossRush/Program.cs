using System;
using System.Text.RegularExpressions;

namespace _2BossRush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n=int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string EnteredInputs = Console.ReadLine();

                string patern = @"\|(?<Boss>[A-Z]{4,})\|\:\#(?<Title>[A-Za-z]{1,}\s[A-Za-z]{1,})\#";
                Regex regex = new Regex(patern);

                bool IsValid = regex.IsMatch(EnteredInputs);

                if (IsValid)
                {
                    MatchCollection Matches = regex.Matches(EnteredInputs);

                    
                    foreach (Match item in Matches)
                    {
                        string Name = item.Groups["Boss"].ToString();
                        string Title= item.Groups["Title"].ToString();

                       
                        int Strength = Name.Length;
                        int Armor=Title.Length;

                        Console.WriteLine($"{Name}, The {Title}");
                        Console.WriteLine($">> Strength: {Strength}");
                        Console.WriteLine($">> Armor: {Armor}");
                    }

                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            
            
            }
        }
    }
}
