using System;
using System.Collections.Generic;
using System.Linq;

namespace _03PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> PlantRrarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> PlantRatings = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string Command1= Console.ReadLine();
                string[] Arr1Cmd = Command1.Split("<->").ToArray();

               
                string Plant=Arr1Cmd[0];
                int Rararity = int.Parse(Arr1Cmd[1]);

                if (PlantRrarity.ContainsKey(Plant))
                {
                    PlantRrarity[Plant] = Rararity;
                }
                else
                {
                    PlantRrarity.Add(Plant, Rararity);
                    PlantRatings.Add(Plant, new List<double>());
                }

            }

            string Command2=String.Empty;

            while ((Command2= Console.ReadLine()) != "Exhibition")
            {
                string[] Arr2Cmd = Command2.Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string CurrentCmd = Arr2Cmd[0];
                string Plant1=Arr2Cmd[1];

                if (CurrentCmd == "Rate")
                {

                    double CurrentRating = double.Parse(Arr2Cmd[2]);
           
                    if (!PlantRatings.ContainsKey(Plant1))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {

                        PlantRatings[Plant1].Add(CurrentRating);
                    }
                    
                }
                else if (CurrentCmd == "Update")
                {
                    int NewRararity =int.Parse(Arr2Cmd[2]);
                    if (!PlantRrarity.ContainsKey(Plant1))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        PlantRrarity[Plant1] = NewRararity;
                    }


                }
                else if (CurrentCmd == "Reset")
                {
                    if (!PlantRrarity.ContainsKey(Plant1))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        PlantRatings[Plant1].Clear();

                    }

                }


            }//Cmd Exhibition

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in PlantRrarity)
            {
                string Plant3 = item.Key;
                double AverageRating = 0.00;
                if (PlantRatings[Plant3].Count > 0)
                {
                    List<double> Ratings = PlantRatings[Plant3];
                    double sumRatings = 0;
                    foreach (var item2 in Ratings)
                    {
                        sumRatings += item2;
                    }
                    AverageRating = sumRatings / Ratings.Count;


                    Console.WriteLine($"- {Plant3}; Rarity: {item.Value}; Rating: {AverageRating:F2}");


                }
                else
                {

                    Console.WriteLine($"- {Plant3}; Rarity: {item.Value}; Rating: 0.00");

                }


            }


        }
    }
}
