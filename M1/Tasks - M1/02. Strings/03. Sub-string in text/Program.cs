using System;

class Program
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        int occurs = GetOccurCount(pattern, text);

        Console.WriteLine(occurs);
    }

    private static int GetOccurCount(string pattern, string text, int occurIndex = 0, int counter = 0)
    {
        occurIndex = text.IndexOf(pattern, occurIndex);

        if (occurIndex == -1)
            return counter;

        return GetOccurCount(pattern, text, occurIndex + 1, counter + 1);
    }
}
