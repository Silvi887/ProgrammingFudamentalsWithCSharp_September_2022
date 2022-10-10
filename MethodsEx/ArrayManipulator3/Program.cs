using System;
using System.Linq;

namespace ArrayManipulator3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string enteredArr = Console.ReadLine();
            int[] Arr1 = enteredArr.Split(' ', StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            string command = "";// Komandi za masiva

            while ((command = Console.ReadLine()) != "end")

            {

                string[] CommdArr = command.Split(' ', StringSplitOptions
                                .RemoveEmptyEntries)
                                .ToArray();


                if (CommdArr[0] == "exchange")
                {
                    int n = int.Parse(CommdArr[1]);

                    if (n < 0 || n >= Arr1.Length)
                    {// ne e izvyn granicite na masiva
                        Console.WriteLine("Invalid index");
                        continue;

                    }
                    else //Invalid Index
                    {
                        Arr1 = RotateArrayByGivenN(Arr1, n);
                       
                    }
                }
                else if (CommdArr[0] == "max" || CommdArr[0] =="min")
                {
                    string evenOrOddArg = CommdArr[1];
                    int indexOfEl;
                    if (CommdArr[0] == "max")
                    {
                        indexOfEl = IndexOfMaxEvenOrOddElement(Arr1, evenOrOddArg);
                    }
                    else
                    {
                        indexOfEl = IndexOfMinEvenOrOddElement(Arr1, evenOrOddArg);
                    }

                    if (indexOfEl == -1)
                    {
                        //No matching element
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(indexOfEl);
                }
                //else if (CommdArr[0] == "max")
                //{
                //    ReturnMaxIndexOfEvenOddNumber(CommdArr[1].ToString(), Arr1);
                   


                //}
                //else if (CommdArr[0] == "min")
                //{
                //    ReturnMinIndexOfEvenOddNumber(CommdArr[1].ToString(), Arr1);
                   

                //}
                else  if (CommdArr[0] == "first")
                {
                    int p = int.Parse(CommdArr[1]);

                    if (p > Arr1.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        ReturnFirstNEvenOdd(CommdArr[2].ToString(), Arr1, p);
                    }
                }
                else if (CommdArr[0] == "last")
                {
                    int p = int.Parse(CommdArr[1]);
                    if (p > Arr1.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        ReturnLastNEvenOdd(CommdArr[2].ToString(), Arr1, p);

                    }
                }


            }

            if (command == "end")
            {
                Console.WriteLine("[" + string.Join(", ", Arr1) + "]");
            }
        }//End Main

        ///Course Desition
         //Returns the index of the max even/odd element if found
        //If there is no matching element it returns -1
        static int IndexOfMaxEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            //Default value for maxIndex which means there is no match
            int maxIndex = -1;
            int currMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
            }

            return maxIndex;
        }

        static int IndexOfMinEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            int minIndex = -1;
            int currMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }






        /// <summary>
        /// My desition Old
        /// </summary>
        /// <param name="evenodd"></param>
        /// <param name="Arr1"></param>
        //static void ReturnMaxIndexOfEvenOddNumber(string evenodd, int[] Arr1)
        //{

        //    int MaxNum = int.MinValue;
        //    int IndexMax = -1;
        //    int countIndexmax = 0;
        //    if (evenodd == "even")//чetno Even
        //    {

        //        for (int i = 0; i < Arr1.Length; i++)
        //        {
        //            if (Arr1[i] % 2 == 0)
        //            {
        //                if (Arr1[i] >= MaxNum)
        //                {
        //                    MaxNum = Arr1[i];
        //                    IndexMax = i;
        //                }
        //                countIndexmax++;
        //            }
        //        }

        //        // Console.WriteLine(IndexMax);

        //    }
        //    else if (evenodd == "odd")
        //    {
        //        for (int i = 0; i < Arr1.Length; i++)
        //        {
        //            if (Arr1[i] % 2 == 1)  //Odd
        //            {
        //                if (Arr1[i] >= MaxNum)
        //                {
        //                    MaxNum = Arr1[i];
        //                    IndexMax = i;
        //                }
        //            }

        //            countIndexmax++;
        //        }
        //    }

        //    //if (countIndexmax < 1)
        //    //{
        //    //    Console.WriteLine("No matches");
        //    //}
        //    if (IndexMax == -1)
        //    {
        //        Console.WriteLine("No matches");
        //    }
        //    else
        //    {
        //        Console.WriteLine(IndexMax);
        //    }
        //    // return IndexMax;
        //}

        //static void ReturnMinIndexOfEvenOddNumber(string evenodd, int[] Arr1)
        //{

        //    int MinNum = int.MaxValue;
        //    int IndexMin = -1;
        //    int countIndexmin = 0;

        //    if (evenodd == "even")//чetno Even
        //    {

        //        for (int i = 0; i < Arr1.Length; i++)
        //        {
        //            if (Arr1[i] % 2 == 0)
        //            {
        //                if (Arr1[i] <= MinNum)
        //                {
        //                    MinNum = Arr1[i];
        //                    IndexMin = i;
        //                }
        //                countIndexmin++;
        //            }

        //        }

        //        // Console.WriteLine(IndexMax);

        //    }
        //    else if (evenodd == "odd")
        //    {
        //        for (int i = 0; i < Arr1.Length; i++)
        //        {
        //            if (Arr1[i] % 2 == 1)  //Odd
        //            {
        //                if (Arr1[i] <= MinNum)
        //                {
        //                    MinNum = Arr1[i];
        //                    IndexMin = i;
        //                }
        //                countIndexmin++;
        //            }
        //        }
        //    }

        //    //if (countIndexmin<1)
        //    //{
        //    //    Console.WriteLine("No matches");
        //    //}
        //    if (IndexMin == -1)
        //    {
        //        Console.WriteLine("No matches");
        //    }
        //    else
        //    {
        //        Console.WriteLine(IndexMin);
        //    }

        //}
        static void ReturnFirstNEvenOdd(string evenodd, int[] Arr1, int n)
        {

            //int MinNum = int.MaxValue;
            //int IndexMin = 0;

            //string firstNum = "";
            //string secondNum = "";
            int j = 0;
            int[] ArrFirst = new int[n];
            if (evenodd == "even")//чetno Even
            {
              
                for (int i = 0; i < Arr1.Length; i++)
                {
                    if (j > (n - 1))
                    {
                        break;
                    }
                    if (Arr1[i] % 2 == 0)// Even
                    {

                        if (j < ArrFirst.Length)
                        {

                            ArrFirst[j] = Arr1[i];

                        }
                        j++;
                    }

                }
                ArrFirst = Array1(ArrFirst, j);
                Console.WriteLine("[" + String.Join(", ", ArrFirst) + "]");

            }
            else if (evenodd == "odd")
            {
               // int j = 0;
                for (int i = 0; i < Arr1.Length; i++)
                {
                    if (j > (n - 1))
                    {
                        break;
                    }

                    if (Arr1[i] % 2 == 1)  //Odd
                    {
                        if (j < ArrFirst.Length)
                        {


                            ArrFirst[j] = Arr1[i];
                            j++;
                        }



                    }

                }

                ArrFirst = Array1(ArrFirst, j);
                Console.WriteLine("[" + String.Join(", ", ArrFirst) + "]");
            }

        } //End  ReturnFirstTwoEvenOdd

        static int[] Array1(int[] Arr1, int count1)
        {
            int[] Arr3 = new int[count1];
            for (int i = 0; i < count1; i++)
            {
                Arr3[i] = Arr1[i];
            }
            return Arr3;

        }

        static int[] ReverseArr(int[] Arr1, int count1) //Obryshtane na masiv
        {
            int[] Arr2 = new int[count1];
            for (int i = Arr1.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < Arr2.Length; j++)
                {
                    Arr2[j] = Arr1[i];
                }

            }
            return Arr2;

        }
        static void ReturnLastNEvenOdd(string evenodd, int[] Arr1, int n)
        {

            //int MinNum = int.MaxValue;
            //int IndexMin = 0;

            //string firstNum = "";
            //string secondNum = "";
            int j = 0;
            int[] ArrLast = new int[n];
            if (evenodd == "even")//чetno Even
            {
               
                for (int i = Arr1.Length - 1; i >= 0; i--)
                {

                    if (j > (n - 1))
                    {
                        break;
                    }

                    if (Arr1[i] % 2 == 0)// Even
                    {

                        ArrLast[j] = Arr1[i];
                        j++;

                    }

                }
                int s = 0;
                for (int l = 0; l < ArrLast.Length; l++)
                {
                    s += ArrLast[l];
                }

                if (s == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    ArrLast = Array1(ArrLast, j);
                    ReverseArr(ArrLast, ArrLast.Length);
                    Console.WriteLine("[" + String.Join(", ", ArrLast) + "]");
                }

            }
            else if (evenodd == "odd")
            {
               // int j = 0;
                for (int i = Arr1.Length - 1; i >= 0; i--)
                {

                    if (j > (n - 1))
                    {
                        break;
                    }
                    if (Arr1[i] % 2 == 1)// Even
                    {

                        ArrLast[j] = Arr1[i];
                        j++;

                    }

                }
                int s = 0;
                for (int l = 0; l < ArrLast.Length; l++)
                {
                    s += ArrLast[l];
                }

                if (s == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    ArrLast = Array1(ArrLast, j);
                    ReverseArr(ArrLast, ArrLast.Length);
                    Console.WriteLine("[" + String.Join(", ", ArrLast) + "]");
                }
            }

        } //End  ReturnLastNEvenOdd

        static int[] RotateArrayByGivenN(int[] numbers, int num)
        {
            int[] newarr = new int[numbers.Length];
            int n = num + 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (n >= numbers.Length)
                {
                    n = 0;
                }
                newarr[i] = numbers[n];
                n++;
            }
            return newarr;
        }
    }
}
