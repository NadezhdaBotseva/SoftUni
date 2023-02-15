using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(?<separator>[\.|\/]|-)(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})";

            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
