using System;
using System.Collections.Generic;
using System.Linq;

namespace _03P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Command1 = String.Empty;

            Dictionary<string, int> PoulationCities = new Dictionary<string, int>();
            Dictionary<string, int> GoldCities = new Dictionary<string, int>();


            while ((Command1 = Console.ReadLine()) != "Sail")
            {
                string[] ArrCmd = Command1.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string city = ArrCmd[0];
                int population = int.Parse(ArrCmd[1]);
                int gold = int.Parse(ArrCmd[2]);


                if (PoulationCities.ContainsKey(city))
                {
                    PoulationCities[city] += population;
                    GoldCities[city] += gold;
                }
                else
                {
                    PoulationCities.Add(city, population);
                    GoldCities.Add(city, gold);
                }

            }

            string Command2 = String.Empty;
            while ((Command2 = Console.ReadLine()) != "End")
            {
                string[] ArrCmd2 = Command2.Split("=>").ToArray();
                string CurrentCmd = ArrCmd2[0];
                string Town = ArrCmd2[1];
                if (CurrentCmd == "Plunder")// Ograbvane
                {

                    int People = int.Parse(ArrCmd2[2]);
                    int Gold = int.Parse(ArrCmd2[3]);

                    int NewPopulation = PoulationCities[Town] - People;
                    PoulationCities[Town] = NewPopulation;

                    int NewAmmountGold = GoldCities[Town] - Gold;
                    GoldCities[Town] = NewAmmountGold;

                    // GoldCities[Town] -= Gold;
                    Console.WriteLine($"{Town} plundered! {Gold} gold stolen, {People} citizens killed.");


                    if (PoulationCities[Town] == 0 || GoldCities[Town] == 0)
                    {
                        PoulationCities.Remove(Town);
                        GoldCities.Remove(Town);
                        Console.WriteLine($"{Town} has been wiped off the map!");
                    }

                }
                else if (CurrentCmd == "Prosper")
                {
                    int Gold1 = int.Parse(ArrCmd2[2]);
                    if (Gold1 < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        GoldCities[Town] += Gold1;
                        int TotalGold = GoldCities[Town];
                        Console.WriteLine($"{Gold1} gold added to the city treasury. {Town} now has {TotalGold} gold.");
                    }

                }


            }

            if (PoulationCities.Count > 0 && GoldCities.Count > 0)
            {
                int CountCities = PoulationCities.Count;
                Console.WriteLine($"Ahoy, Captain! There are {CountCities} wealthy settlements to go to:");

                foreach (var item in PoulationCities)
                {
                    string City = item.Key;
                    Console.WriteLine($"{item.Key} -> Population: {PoulationCities[City]} citizens, Gold: {GoldCities[City]} kg");
                }

            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
