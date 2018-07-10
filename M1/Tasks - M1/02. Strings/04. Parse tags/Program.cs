using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        while (text.Contains("<<") && text.Contains(">>"))
        {
            int firstIndex = text.IndexOf("<<");
            int lastIndex = text.IndexOf(">>") + 2;

            string oldSubText = text.Substring(firstIndex, lastIndex - firstIndex);
            string newSubText = oldSubText.Substring(2, oldSubText.Length - 4).ToUpper();

            text = text.Replace(oldSubText, newSubText);
        }

        Console.WriteLine(text);
    }
}
