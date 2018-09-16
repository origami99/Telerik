using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static char[][] matrix;
    private static SortedSet<string> words = new SortedSet<string>();

    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(input[0]);
        int c = int.Parse(input[1]);

        matrix = new char[r][];

        for (int row = 0; row < r; row++)
        {
            matrix[row] = Console.ReadLine().Trim().ToCharArray();
        }

        // search for horizontal words
        for (int row = 0; row < r; row++)
        {
            string word = string.Empty;

            for (int col = 0; col < c; col++)
            {
                char symb = matrix[row][col];

                if (symb == '#')
                {
                    if (word.Length >= 2)
                    {
                        words.Add(word);
                    }

                    word = string.Empty;
                    continue;
                }

                word += symb;
            }

            if (word.Length >= 2)
            {
                words.Add(word);
            }
        }

        // search for vertical word
        for (int col = 0; col < c; col++)
        {
            string word = string.Empty;

            for (int row = 0; row < r; row++)
            {
                char symb = matrix[row][col];

                if (symb == '#')
                {
                    if (word.Length >= 2)
                    {
                        words.Add(word);
                    }

                    word = string.Empty;
                    continue;
                }

                word += symb;
            }

            if (word.Length >= 2)
            {
                words.Add(word);
            }
        }

        Console.WriteLine(words.First());
    }
}
