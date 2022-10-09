using System;

namespace BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string StudentName= Console.ReadLine();
            int age= int.Parse(Console.ReadLine());
            double averageGrade= double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {StudentName} ,Age: {age}, Grade: {averageGrade:F2}");
                
        }
    }
}
