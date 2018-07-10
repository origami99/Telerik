using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        string openingTag = "<upcase>";
        string closingTag = "</upcase>";

        while (text.Contains(openingTag) && text.Contains(closingTag))
        {
            int firstIndex = text.IndexOf(openingTag);
            int lastIndex = text.IndexOf(closingTag) + closingTag.Length;

            string oldSubText = text.Substring(firstIndex, lastIndex - firstIndex);
            string newSubText = oldSubText.Substring(openingTag.Length, oldSubText.Length - (openingTag.Length + closingTag.Length)).ToUpper();

            text = text.Replace(oldSubText, newSubText);
        }

        Console.WriteLine(text);
    }
}
