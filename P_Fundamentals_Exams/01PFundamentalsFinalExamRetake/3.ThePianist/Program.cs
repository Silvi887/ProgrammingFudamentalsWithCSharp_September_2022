using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> Composers = new Dictionary<string, string>();
            Dictionary<string, string> Pieces = new Dictionary<string, string>();
            for (int i = 1; i <= n; i++)
            {
                string command1 = Console.ReadLine();
                string[] ArrComposersPieces = command1.Split('|').ToArray();

                string piece1 = ArrComposersPieces[0];
                string composer1 = ArrComposersPieces[1];
                string key1 = ArrComposersPieces[2];

                Composers.Add(piece1, composer1);
                Pieces.Add(piece1, key1);

            }

            string command2 = string.Empty;

            while ((command2 = Console.ReadLine()) != "Stop")
            {
                string[] ArrPieces = command2.Split('|').ToArray();
                string realCmd = ArrPieces[0];
                string piece2 = ArrPieces[1];

                if (realCmd == "Add")
                {

                    string composer2 = ArrPieces[2];
                    string key2 = ArrPieces[3];
                    if (Pieces.ContainsKey(piece2))// List Contains piece
                    {
                        Console.WriteLine($"{piece2} is already in the collection!");
                        continue;

                    }
                    else
                    {
                        Pieces.Add(piece2, key2);
                        Composers.Add(piece2, composer2);
                        Console.WriteLine($"{piece2} by {composer2} in {key2} added to the collection!");
                    }

                }
                else if (realCmd == "Remove")
                {


                    if (Pieces.ContainsKey(piece2))
                    {
                        Pieces.Remove(piece2);
                        Composers.Remove(piece2);
                        Console.WriteLine($"Successfully removed {piece2}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece2} does not exist in the collection.");
                    }
                    //foreach (var item in Pieces)
                    //{
                    //    if (item.Value== piece2)
                    //    {
                    //        Pieces.Remove(item.Key);//Ako piesata e v kolekciqta premahvame q
                    //    }
                    //}


                }
                else if (realCmd == "ChangeKey")
                {
                    string newKey = ArrPieces[2];
                    if (Pieces.ContainsKey(piece2))//  Contains piece
                    {
                        Pieces[piece2] = newKey;
                        Console.WriteLine($"Changed the key of {piece2} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece2} does not exist in the collection.");
                    }


                }//
            }//End While


            foreach (var item3 in Pieces)
            {

                Console.WriteLine($"{item3.Key} -> Composer: {Composers[item3.Key]}, Key: {item3.Value}");
                //foreach (var item4 in Composers.Where(x=> x.Key == item3.Key))
                //{

                //    Console.WriteLine($"{item3.Key} -> Composer: {item4.Value}, Key: {item3.Value}");
                //}

            }
        }
    }
}
