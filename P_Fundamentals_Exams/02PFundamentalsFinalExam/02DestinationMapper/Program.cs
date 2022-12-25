using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string EnteredString=Console.ReadLine();
            string patern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";


            List<string> Destinations=new List<string>();
            Regex regex = new Regex(patern);
            MatchCollection Mathes= regex.Matches(EnteredString);

            int SumTravelPoints = 0;
            if (Mathes.Count >0)
            {
                foreach (Match item in Mathes)
                {
                  
                    string CurrentDestination = item.Groups["destination"].ToString();
                    Destinations.Add(CurrentDestination);
                    SumTravelPoints += CurrentDestination.Length;
                }

            }

            Console.WriteLine("Destinations: " + String.Join(", ", Destinations));

            Console.WriteLine($"Travel Points: {SumTravelPoints}");
        }
    }
}
