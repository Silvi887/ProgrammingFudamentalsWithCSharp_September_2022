using System;
using System.Text.RegularExpressions;

namespace _2AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string EnteredString= Console.ReadLine();

            string patern = @"(\||\#)(?<Itemname>[A-Za-z ]+)(\1)(?<Expirationdate>\d{2}\/\d{2}\/\d{2})(\1)(?<Calories>\d+)(\1)";

            Regex regex = new Regex(patern);

            bool isValid = regex.IsMatch(EnteredString);


            int countCalories = 0;
            MatchCollection matches = regex.Matches(EnteredString);

            if (matches.Count>0)
            {
                foreach (Match item in matches)
                {
                    int currentCalories=int.Parse(item.Groups["Calories"].ToString());

                    countCalories += currentCalories;
                }
            }


            int DaysNeedeCalories = countCalories / 2000;

            Console.WriteLine($"You have food to last you for: {DaysNeedeCalories} days!");


            MatchCollection matches2 = regex.Matches(EnteredString);
            string ItemName = "";
            string ExpirationDate = "";
            int Calories = 0;
            if (matches2.Count > 0)
            {
                foreach (Match item in matches2)
                {
                     ItemName = item.Groups["Itemname"].ToString();
                     ExpirationDate= item.Groups["Expirationdate"].ToString();
                     Calories = int.Parse(item.Groups["Calories"].ToString());
                   
                    
                    Console.WriteLine($"Item: {ItemName}, Best before: {ExpirationDate}, Nutrition: {Calories}");

                }
            }




        }
    }
}
