using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string sentence = Console.ReadLine();

        // doesn't support multiple chars at the end, like: (...), (?!), etc.
        char lastSymb = sentence.Last(); 
        sentence = sentence.Remove(sentence.Length - 1);

        string[] sentenceElements = Regex.Split(sentence, @"([\s\,\-]+)");
        sentenceElements = sentenceElements.Reverse().ToArray();

        string reversed = string.Join("", sentenceElements) + lastSymb;
        Console.WriteLine(reversed);
    }
}
