using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();

            var pattern = @"(^|(?<=\s))-?[0-9]+(\.\d+)?($|(?=\s))";

            var posNumbers = Regex.Matches(numbers, pattern);

            foreach (Match item in posNumbers)
            {
               

                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
