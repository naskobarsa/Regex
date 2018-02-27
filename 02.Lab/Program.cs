using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var phones = Console.ReadLine();

            var pattern = @"\+359+(-| ?)2(\1)[\d]{3}(\1)[\d]{4}\b";

            var phonesMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phonesMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
