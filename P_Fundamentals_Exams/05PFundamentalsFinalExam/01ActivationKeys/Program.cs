using System;
using System.Linq;
using System.Text;

namespace _01ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MessageActivationKeys = Console.ReadLine();

           
            StringBuilder sb = new StringBuilder();

            sb.Append(MessageActivationKeys);

            string Command1 = string.Empty;
            while ((Command1 = Console.ReadLine()) != "Generate")
            {
                string[] cmdArray = Command1.Split(">>>").ToArray();
                string cmdType = cmdArray[0];

                if (cmdType == "Contains")
                {
                    string Substring = cmdArray[1];
                    if (sb.ToString().Contains(Substring))
                    {
                        Console.WriteLine($"{sb.ToString()} contains {Substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                else if (cmdType == "Flip")
                {
                    string UpperLower = cmdArray[1];
                    int startIndex = int.Parse(cmdArray[2]);
                    int endiNDEX = int.Parse(cmdArray[3]);

                    string NewString = sb.ToString().
                          Substring(startIndex, endiNDEX - startIndex);

                    if (UpperLower == "Upper")
                    {
                        NewString = NewString.ToUpper();
                    }
                    else if (UpperLower == "Lower")
                    {
                        NewString = NewString.ToLower();
                    }

                    sb.Remove(startIndex, endiNDEX - startIndex);
                    sb.Insert(startIndex, NewString);
                    Console.WriteLine(sb.ToString());


                }
                else if (cmdType == "Slice")
                {
                    int startIndex = int.Parse(cmdArray[1]);
                    int endIndex = int.Parse(cmdArray[2]);

                    sb.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(sb.ToString());

                }


            }


            Console.WriteLine($"Your activation key is: {sb.ToString()}");
        }
    }
}
