using System;
using System.Linq;

namespace _1SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {


            string RevealMessage = Console.ReadLine();

            string Command1 = String.Empty;
            while ((Command1=Console.ReadLine())!= "Reveal")
            {
                string[] ArrCmd = Command1.Split(":|:").ToArray();
                string CurrentCmd = ArrCmd[0];

                if (CurrentCmd == "InsertSpace")
                {
                    int Index = int.Parse(ArrCmd[1]);
                    RevealMessage=RevealMessage.Insert(Index, " ");
                    Console.WriteLine(RevealMessage);

                }
                else if (CurrentCmd== "Reverse")
                {
                    string Substring = ArrCmd[1];
                    if (RevealMessage.Contains(Substring))
                    {
                        string NeSubstring = "";
                        int IndexString = RevealMessage.IndexOf(Substring);
                        RevealMessage= RevealMessage.Remove(IndexString, Substring.Length);

                        for (int i = Substring.Length-1; i >=0 ; i--)
                        {
                            NeSubstring += Substring[i];
                        }

                        RevealMessage += NeSubstring;

                        Console.WriteLine(RevealMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                      
                    }
                   

                }
                else if (CurrentCmd== "ChangeAll")
                {
                    string Substring = ArrCmd[1];
                    string ReplaceString = ArrCmd[2];

                    RevealMessage= RevealMessage.Replace(Substring, ReplaceString);
                    Console.WriteLine(RevealMessage);

                }
            }

            Console.WriteLine($"You have a new text message: {RevealMessage}");
        }
    }
}
