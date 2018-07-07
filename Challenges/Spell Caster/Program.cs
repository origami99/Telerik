using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();

        int maxLength = words.Select(x => x.Length).Max();

        string result = string.Empty;
        for (int i = 0; i < maxLength; i++)
        {
            char[] line = words.Where(x => i < x.Length).Select(x => x[i]).ToArray();
            result += new string(line);
        }

        for (int i = 0; i < result.Length; i++)
        {
            char letter = result[i];

            int alphabetPos = char.ToUpper(letter) - 64;
            int newPos = alphabetPos % result.Length;

            result = result.Insert(newPos, $"{letter}");

            if (newPos > i)
            {
                result = result.Remove(i - 1, 1);
            }
            else
            {
                result = result.Remove(i, 1);
            }
        }

        Console.WriteLine(result);
    }
}
