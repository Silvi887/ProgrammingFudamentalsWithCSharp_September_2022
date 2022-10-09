using System;

namespace _6Balanced_Brakets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           // string firstbarcket = "";
            string firstbrasketes = "";
            string secondbrackets = "";

            int isTrue = 0;
            int isFalse = 0;

            for (int i =1; i<=n; i++)
			
            {
                string enteredText = Console.ReadLine();

                switch (enteredText) {
                    case "(":
                        if (firstbrasketes == "(")
                        {
                            isFalse++;
                        }
                        else if (firstbrasketes == "")
                        {
                            isTrue++;
                        }
                        firstbrasketes = "(";
                        //secondbrackets = " ";
                       // isTrue = false;
                        break;
                    case ")":
                        if (firstbrasketes == "(")
                        {
                            secondbrackets = ")";
                            isTrue++;
                            // Console.WriteLine("BALANCED");
                            firstbrasketes = "";
                            secondbrackets = "";
                        }
                        else
                        {
                            isFalse++;
                            // Console.WriteLine("UNBALANCED");
                            firstbrasketes = "";
                            secondbrackets = "";
                        }
                        break;
                }
            }

            if(isFalse ==0 && isTrue>0)
            {
                Console.WriteLine("BALANCED");
            }
            else if(isFalse > 0)
            {
                Console.WriteLine("UNBALANCED");
            }
         }
    }
    }
