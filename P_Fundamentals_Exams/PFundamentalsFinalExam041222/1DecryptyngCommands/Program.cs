using System;
using System.Linq;

namespace _1DecryptyngCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string EnteredString = Console.ReadLine();

            string Command1 = String.Empty;

            while ((Command1 = Console.ReadLine()) != "Finish")
            {
                string[] ArrCmd = Command1.Split(" ").ToArray();
                string CurrentCmd = ArrCmd[0];

                if (CurrentCmd == "Replace")
                {
                    string CurrentChar = ArrCmd[1];
                    string NewChar = ArrCmd[2];
                    EnteredString = EnteredString.Replace(CurrentChar, NewChar);
                    Console.WriteLine(EnteredString);
                }
                else if (CurrentCmd == "Cut")
                {
                    int StarIndex = int.Parse(ArrCmd[1]);
                    int EndIndex = int.Parse(ArrCmd[2]);
                    bool IsvaidFirstIndex = ValidIndexes(EnteredString, StarIndex);
                    bool IsvaidEndIndex = ValidIndexes(EnteredString, EndIndex);

                    if (IsvaidFirstIndex && IsvaidEndIndex)
                    {
                        EnteredString = EnteredString.Remove(StarIndex, EndIndex - StarIndex + 1);
                        Console.WriteLine(EnteredString);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                 

                }
                else if (CurrentCmd == "Make")
                {
                    string UpperLowe = ArrCmd[1];
                    if (UpperLowe == "Upper")
                    {
                        EnteredString = EnteredString.ToUpper();
                    }
                    else if (UpperLowe == "Lower")
                    {
                        EnteredString = EnteredString.ToLower();
                    }
                    Console.WriteLine(EnteredString);

                }
                else if (CurrentCmd == "Check")
                {
                    string CurrenString = ArrCmd[1];
                    if (EnteredString.Contains(CurrenString))
                    {
                        Console.WriteLine($"Message contains {CurrenString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {CurrenString}");
                    }

                }
                else if (CurrentCmd == "Sum")
                {
                    int StarIndex = int.Parse(ArrCmd[1]);
                    int EndIndex = int.Parse(ArrCmd[2]);
                    bool IsvaidFirstIndex1 = ValidIndexes(EnteredString, StarIndex);
                    bool IsvaidEndIndex1 = ValidIndexes(EnteredString, EndIndex);

                    if (IsvaidFirstIndex1 && IsvaidEndIndex1)
                    {
                        string Substring = EnteredString.Substring(StarIndex, EndIndex - StarIndex + 1);
                        int SumValues = 0;

                        for (int i = 0; i < Substring.Length; i++)
                        {
                            SumValues += (int)Substring[i];
                        }
                        Console.WriteLine(SumValues);

                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }


                }
            }

        }
        static bool ValidIndexes(string EnteredString, int Index1)
        {
            if (Index1>=0 && Index1 <= EnteredString.Length-1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
