using System;
using System.Text.RegularExpressions;

namespace _02FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(@\#+)(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])(@\#+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 1;  i <=n; i++)
            {
                string EnteredCode = Console.ReadLine();
                Regex regex = new Regex(patern);
                MatchCollection Matches = regex.Matches(EnteredCode);

                if (Matches.Count >0)
                {
                    foreach (Match item in Matches)
                    {
                       string ProductGroup = "";
                       string CurrentBarCode= item.Groups["barcode"].ToString();

                        foreach (char ch in CurrentBarCode)
                        {
                            int k = (int)ch;
                            if (char.IsDigit(ch))
                            {
                                ProductGroup += (char)ch;
                            }
                        }

                        if (ProductGroup=="")
                        {
                            Console.WriteLine("Product group: 00");
                        }
                        else
                        {
                            Console.WriteLine($"Product group: {ProductGroup}");
                        }
                      
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

         
        }
    }
}
