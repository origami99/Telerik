using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string htmlCode = Console.ReadLine();

        Regex regex = new Regex(@"\<a href=""(?<url>[\w\:\/\.]+)""\>(?<text>[\w\s]+)\<\/a\>");
        MatchCollection matches = regex.Matches(htmlCode);

        foreach (Match match in matches)
        {
            string url = match.Groups["url"].Value;
            string text = match.Groups["text"].Value;

            string newValue = $"[{text}]({url})";

            htmlCode = htmlCode.Replace(match.Value, newValue);
        }

        Console.WriteLine(htmlCode);
    }
}
