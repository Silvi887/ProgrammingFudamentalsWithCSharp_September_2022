using System;

namespace _3Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int countPeople=int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceVacation = 0;


            switch (dayOfWeek)
            {
                case "Friday":

                    switch (typeGroup)
                    {
                        case "Students":
                            priceVacation = 8.45;
                            
                            break;
                        case "Business":
                            priceVacation = 10.90;
                           
                            break;
                        case "Regular":
                            priceVacation = 15;

                           
                                break;

                    }

                    break;
                case "Saturday":
                    switch (typeGroup)
                    {
                        case "Students":
                            priceVacation = 9.80;
                           
                            break;
                        case "Business":
                            priceVacation = 15.60;
                         
                            break;
                        case "Regular":
                            priceVacation =20;
                           
                            break;

                    }

                    break;
                case "Sunday":
                    switch (typeGroup)
                    {
                        case "Students":
                            priceVacation = 10.46;
                            
                            break;
                        case "Business":
                            priceVacation = 16;
                           
                            break;
                        case "Regular":
                            priceVacation = 22.50;
                          
                            break;

                    }

                    break;
            }

            double totalPrice = priceVacation * countPeople;
            //Exact Order Reduce
            switch (typeGroup)
            {
                case "Students":
                  
                    if (countPeople >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                    break;
                case "Business":
                  
                    if (countPeople >= 100)
                    {
                        countPeople = countPeople - 10;
                    }
                    break;
                case "Regular":
                 

                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:F2}");



        }
    }
}
