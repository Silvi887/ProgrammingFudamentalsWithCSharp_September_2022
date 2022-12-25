using System;
using System.Linq;

namespace _01WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {

            bool istrue = 100f == 100d;

            Console.WriteLine(istrue);

            //int a = 10;
            //int b = 20;
            //int c= a>b ? a : b;
            //Console.WriteLine(c);


            //bool isTrue = true;
            //int value = int.Parse(isTrue);
            //Console.WriteLine(value);

            //for (int i = 10; i > 3; i -=2)
            //{
            //    Console.Write($"{i}");
            //}



        //    int a = 5;
        //    int b = a++;
        //    int c = ++a;
        //    Console.WriteLine(c);

        //    string StringMessage = Console.ReadLine();

        //    string Command1 = string.Empty;

        //    while ((Command1=Console.ReadLine())!= "Travel")
        //    {
        //        string[] ArrCmd = Command1.Split(":").ToArray();
        //        string CurrentCmd = ArrCmd[0];

        //        if (CurrentCmd == "Add Stop")
        //        {
        //            int Index =int.Parse(ArrCmd[1]);
        //            string CurrentString = ArrCmd[2];
        //          bool ValidIndex = IsValidIndex(StringMessage, Index);
        //            if(ValidIndex)
        //            {
        //                StringMessage = StringMessage.Insert(Index, CurrentString);
        //            }
        //            Console.WriteLine(StringMessage);

        //        }
        //        else if (CurrentCmd == "Remove Stop")
        //        {
        //            int StartIndex = int.Parse(ArrCmd[1]);
        //            int EndIndex = int.Parse(ArrCmd[2]);

        //            bool ValidFirst= IsValidIndex(StringMessage, StartIndex);
        //            bool ValidSecond= IsValidIndex(StringMessage, EndIndex);
        //            if (ValidFirst && ValidSecond)
        //            {
        //                StringMessage = StringMessage.Remove(StartIndex, (EndIndex - StartIndex) + 1);

        //            }
        //            Console.WriteLine(StringMessage);

        //        }
        //        else if (CurrentCmd == "Switch")
        //        {
        //            string OldString = ArrCmd[1];
        //            string NewString = ArrCmd[2];

        //            if (StringMessage.Contains(OldString))
        //            {
        //                StringMessage = StringMessage.Replace(OldString, NewString);
        //            }
        //            Console.WriteLine(StringMessage);
        //        }

        //    }
        //    Console.WriteLine($"Ready for world tour! Planned stops: {StringMessage}");

        //}

        //static bool IsValidIndex(string StringMessage, int Index)
        //{
        //    if (Index >=0 && Index <= StringMessage.Length-1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        }
    }
}
