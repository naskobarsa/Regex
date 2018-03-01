using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string inputLine = Console.ReadLine();
        string pattern = @"(\d+)([A-Za-z])";
        

        MatchCollection replacer = Regex.Matches(inputLine, pattern);

        foreach (Match find in replacer)
        {
            inputLine = Regex.Replace(inputLine, find.Groups[1].ToString(), find.Groups[2].Value.ToString());
        }
        Console.WriteLine(inputLine);
    }
}