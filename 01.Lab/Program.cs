using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
      
        string input = @"Ivan IvanovE, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov
";      string replacement = "nn";
        Regex regex = new Regex(@"[A-Z]+([a-z])");
        var options = regex.Matches(input);
        string newregex = regex.Replace(input, replacement);
        foreach (Match item in options)
        {

            Console.WriteLine(item.Groups[1].Index);
        }

        Console.WriteLine(newregex);
    }
}
