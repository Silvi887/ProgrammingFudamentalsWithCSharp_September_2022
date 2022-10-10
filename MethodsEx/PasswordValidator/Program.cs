using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password = Console.ReadLine();
           
            bool isValid = true;// 6-10 characters
            bool isContainsLetNumbers = true;
            bool atLeastTwoDigits = true;

            //1
            if (Password.Length<6 || Password.Length> 10) 
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            else
            {
                isValid = true;
            }

           //2
            isContainsLetNumbers=Regex.IsMatch(Password, @"^[a-zA-Z0-9]+$");//Only Letters na d digits
            if (!isContainsLetNumbers)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                isContainsLetNumbers = true;
            }

            
            //3
            int countnumbers = 0;
            for (int i = 0; i < Password.Length; i++)
            {

                int myInt;
                string a = Password[i].ToString();
                bool isNumerical = int.TryParse(a, out myInt);
                if (isNumerical== true)
                {
                    countnumbers++;// count digits
                }

            }

            if (countnumbers <2)
            {
                atLeastTwoDigits = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                atLeastTwoDigits = true;
            }

            //last Check for All checks
            if (isValid== true && isContainsLetNumbers == true 
                && atLeastTwoDigits== true)
            {
                Console.WriteLine("Password is valid");
            }


            // int countcharacters = 0;

            //foreach (char c in Password)
            //{
            //    countcharacters++;
            //}
            //if (Password.Containt()
            //{

            //}

        }
    }
}
