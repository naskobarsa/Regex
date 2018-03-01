using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateString = Console.ReadLine();

            var pattern = @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>[0-9]{4})\b";

            var dates = Regex.Matches(dateString, pattern);

            foreach (Match item in dates)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
