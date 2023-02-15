using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            string pattern = @">>[A-Za-z]+<<\d+(\.[0-9]*)?!\d+";

            double totalSum = 0;

            Console.WriteLine("Bought furniture:");

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    string productPattern = @">>[A-Za-z]+<<";

                    var productMatch = Regex.Match(input, productPattern);

                    string productToGet = productMatch.Value;
                    string product = string.Empty;

                    for (int i = 2; i < productToGet.Length - 2; i++)
                    {
                        product += productToGet[i];
                    }

                    string pricePattern = @"\d+(\.[0-9]*)?!";

                    var priceMatch = Regex.Match(input, pricePattern);

                    string priceToGet = priceMatch.Value;
                    string priceString = string.Empty;

                    for (int i = 0; i < priceToGet.Length - 1; i++)
                    {
                        priceString += priceToGet[i];
                    }

                    double price = Double.Parse(priceString);

                    string quantityPattern = @"!\d+";

                    var quantityMatch = Regex.Match(input, quantityPattern);

                    string quantityToGet = quantityMatch.Value;
                    string quantityString = string.Empty;

                    for (int i = 1; i < quantityToGet.Length; i++)
                    {
                        quantityString += quantityToGet[i];
                    }

                    int quantity = int.Parse(quantityString);

                    totalSum += quantity * price;

                    Console.WriteLine($"{product}");
                }
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
