using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var someString = Console.ReadLine();

            var pattern = @"\b(0x)*[0-9A-F]+\b";

            var numbers = Regex.Matches(someString, pattern);

            var matchedNumbers = numbers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}
