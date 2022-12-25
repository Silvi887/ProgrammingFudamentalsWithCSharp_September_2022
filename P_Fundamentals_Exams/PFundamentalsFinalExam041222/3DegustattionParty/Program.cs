using System;
using System.Collections.Generic;
using System.Linq;

namespace _3DegustattionParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> GuestLikedMeals=new Dictionary<string, List<string>>();
            List<string> UnlikedMeals = new List<string>();

            string Command1= String.Empty;
            while ((Command1 = Console.ReadLine()) != "Stop")
            {
                string[] ArrCmd = Command1.Split("-").ToArray();
                string CurrentCmd = ArrCmd[0];

                if (CurrentCmd == "Like")
                {
                    string Guest1 = ArrCmd[1];
                    string meal = ArrCmd[2];
                    if (!GuestLikedMeals.ContainsKey(Guest1))
                    {
                        GuestLikedMeals.Add(Guest1, new List<string>());
                       
                    }

                    if (!GuestLikedMeals[Guest1].Contains(meal))//if Guest doesn't contain in colllection meal
                    {
                        GuestLikedMeals[Guest1].Add(meal);
                    }


                }
                else if (CurrentCmd == "Dislike")

                {
                    string Guest2 = ArrCmd[1];
                    string meal2 = ArrCmd[2];
                    if (!GuestLikedMeals.ContainsKey(Guest2))// Guest doesn't exist
                    {
                        Console.WriteLine($"{Guest2} is not at the party.");
                    }
                    else
                    {
                        if (!GuestLikedMeals[Guest2].Contains(meal2))// Guest exists and meal desn't exist  in Collection
                        {
                            Console.WriteLine($"{Guest2} doesn't have the {meal2} in his/her collection.");
                        }
                        else
                        {
                            GuestLikedMeals[Guest2].Remove(meal2);

                            Console.WriteLine($"{Guest2} doesn't like the {meal2}.");
                            if (!UnlikedMeals.Contains(meal2))//unlikedMeals
                            {
                                UnlikedMeals.Add(meal2);
                            }

                        }
                    }

                }

            }//End while

            PrintGuestsMeals(GuestLikedMeals, UnlikedMeals);


        }

        static void PrintGuestsMeals(Dictionary<string, List<string>> GuestLikedMeals,List<string> UnlikedMeals)
        {
            foreach (var item in GuestLikedMeals)
            {
                string NameGuest = item.Key;
                List<string> Likedmeals = item.Value;

                if (Likedmeals.Count > 0)
                {
                    Console.WriteLine($"{NameGuest}: " + String.Join(", ", Likedmeals));
                }
                else
                {
                    Console.WriteLine($"{NameGuest}:");
                }

            }

            int CountUnlikedmeals = UnlikedMeals.Count();
            Console.WriteLine($"Unliked meals: {CountUnlikedmeals}");
        }


    }
}
