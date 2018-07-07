using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split();

        Stack<char>[] sentence = new Stack<char>[arr.Length]
            .Select((x, y) => new Stack<char>(arr[y])).ToArray();

        string word = string.Empty;

        while (!sentence.All(x => x.Count == 0))
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i].Count != 0)
                {
                    word += sentence[i].Pop();
                }
            }
        }

        char[] result = word.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            int alphabetPos = char.ToLower(result[i]) - 'a' + 1;
            int newPos = (alphabetPos + i) % result.Length;

            ShiftChar(ref result, i, newPos);
        }

        Console.WriteLine(new string(result));
    }

    private static void ShiftChar(ref char[] result, int oldIndex, int newIndex)
    {
        if (oldIndex < newIndex)
        {
            for (int j = oldIndex; j < newIndex; j++)
            {
                char temp = result[j];
                result[j] = result[j + 1];
                result[j + 1] = temp;
            }
        }
        else if (newIndex < oldIndex)
        {
            for (int j = oldIndex; j > newIndex; j--)
            {
                char temp = result[j];
                result[j] = result[j - 1];
                result[j - 1] = temp;
            }
        }
    }
}