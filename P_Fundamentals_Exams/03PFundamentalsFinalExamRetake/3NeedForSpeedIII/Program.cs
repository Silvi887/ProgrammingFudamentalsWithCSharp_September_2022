using System;
using System.Collections.Generic;
using System.Linq;

namespace _3NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> CarMileage = new Dictionary<string, int>();
            Dictionary<string, int> CarFuel = new Dictionary<string, int>();

            for (int i = 1; i <= n; i++)
            {
                string Command1=Console.ReadLine();
                string[] ArrCmd = Command1.Split("|").ToArray();

                string Car=ArrCmd[0];
                int Mileage = int.Parse(ArrCmd[1]);
                int Fuel = int.Parse(ArrCmd[2]);

                CarMileage.Add(Car, Mileage);
                CarFuel.Add(Car, Fuel);

            }

            string Command2 = String.Empty;
            
            while ((Command2=Console.ReadLine()) != "Stop")
            {

                string[] ArrCmd= Command2.Split(" : ").ToArray();
                string FirstCmd = ArrCmd[0];

                string Car = ArrCmd[1];
                if (FirstCmd == "Drive")
                {
                    int Distance = int.Parse(ArrCmd[2]);
                    int Fuel = int.Parse(ArrCmd[3]);
                    if (CarFuel[Car] <Fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        CarMileage[Car] += Distance;
                        CarFuel[Car] -= Fuel;

                        Console.WriteLine($"{Car} driven for {Distance} kilometers. {Fuel} liters of fuel consumed.");

                        if (CarMileage[Car]>= 100000)
                        {
                            CarMileage.Remove(Car);
                            CarFuel.Remove(Car);
                            Console.WriteLine($"Time to sell the {Car}!");

                        }
                    }

                }
                else if (FirstCmd == "Refuel")
                {
                    int Fuel = int.Parse(ArrCmd[2]);
                    int NewFule = CarFuel[Car] + Fuel;
                    if (NewFule >75)
                    {
                        Fuel= 75-CarFuel[Car];

                    }
                    
                        CarFuel[Car] += Fuel;
                    

                    Console.WriteLine($"{Car} refueled with {Fuel} liters");

                }
                else if (FirstCmd == "Revert")
                {
                    int Kilometers = int.Parse(ArrCmd[2]);
                   
                    int CurrentMileage= CarMileage[Car] - Kilometers;

                    if (CurrentMileage < 10000)
                    {
                        CarMileage[Car] = 10000;
                    }
                    else
                    {
                        CarMileage[Car] -= Kilometers;
                        Console.WriteLine($"{Car} mileage decreased by {Kilometers} kilometers");
                    }

                }
            }


            foreach (var item in CarMileage)
            {
                string Car = item.Key;
                Console.WriteLine($"{item.Key} -> Mileage: {CarMileage[Car]} kms, Fuel in the tank: {CarFuel[Car]} lt.");
            }

            
        }
    }
}
