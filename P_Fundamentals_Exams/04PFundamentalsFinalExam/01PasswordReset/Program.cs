using System;
using System.Linq;

namespace _01PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {

            string EnteredText = Console.ReadLine();

            string Command1 = string.Empty;

            while ((Command1= Console.ReadLine())!= "Done")
            {
                string[] ArrCmd = Command1.Split(" ").ToArray();

                string CurrentCmd = ArrCmd[0];


                string NewPasswordRaw = "";
                if (CurrentCmd == "TakeOdd")
                {

                    for (int i = 0; i < EnteredText.Length; i++)
                    {
                        int res = i % 2;
                        if (i % 2 !=0)//Odd Number
                        {
                            NewPasswordRaw += EnteredText[i];
                        }

                    }
                    EnteredText = NewPasswordRaw;
                    Console.WriteLine(NewPasswordRaw);

                }
                else if (CurrentCmd == "Cut" )
                {
                    int Index = int.Parse(ArrCmd[1]);
                    int Lenght1= int.Parse(ArrCmd[2]);
                    EnteredText = EnteredText.Remove(Index, Lenght1);

                    Console.WriteLine(EnteredText);
                }
                else if (CurrentCmd == "Substitute")
                {
                    string Substring = ArrCmd[1];
                    string Substitute = ArrCmd[2];
                    if (EnteredText.Contains(Substring))
                    {
                        EnteredText=EnteredText.Replace(Substring, Substitute);
                        Console.WriteLine(EnteredText);

                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }      
            }//End Done

            Console.WriteLine($"Your password is: {EnteredText}");
        }
    }
}
