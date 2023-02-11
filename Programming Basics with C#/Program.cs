using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int budget = int.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                int people = int.Parse(Console.ReadLine());
                double price = 0;
                bool isValid = true;

                switch (season)

                {
                    case "Spring":
                        {
                            if (people <= 6)
                            {
                                price = 3000 * 0.9;
                            }
                            else if (people >= 7 && people <= 11)
                            {
                                price = 3000 * 0.85;
                            }
                            else if (people >= 12)
                            {
                                price = 3000 * 0.75;
                            }
                        }
                        break;

                    case "Summer":
                    case "Autumn":
                        {
                            if (people <= 6)
                            {
                                price = 4200 * 0.9;
                            }
                            else if (people >= 7 && people <= 11)
                            {
                                price = 4200 * 0.85;
                            }
                            else if (people >= 12)
                            {
                                price = 4200 * 0.75;
                            }
                        }
                        break;

                    case "Winter":
                        {
                            if (people <= 6)
                            {
                                price = 2600 * 0.9;
                            }
                            else if (people >= 7 && people <= 11)
                            {
                                price = 2600 * 0.85;
                            }
                            else if (people >= 12)
                            {
                                price = 2600 * 0.75;
                            }
                        }
                        break;
                    default:
                        {
                            isValid = false;
                        }
                        break;
                }

                if (isValid && people % 2 == 0 && season != "Winter" && budget >= price)
                {
                    Console.WriteLine($"Yes! You have {(budget - (price * 0.95)):f2} leva left.");
                }
                else if (isValid && budget >= price)
                {
                    Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
                }
            }
        }
    }
}
