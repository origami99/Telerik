using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = $@"[^.?!]*(?<=[.?\s!]){word}(?=[\s.?!])[^.?!]*[.?!]";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        MatchCollection sentences = regex.Matches(text);

        foreach (Match sentence in sentences)
        {
            Console.WriteLine(sentence.Value.TrimStart());
        }
    }
}
