using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int r = size[0];
        int c = size[1];

        string[][] matrix = new string[r][];

        for (int row = 0; row < r; row++)
        {
            matrix[row] = Console.ReadLine().Split();
        }

        HashSet<int> allOccurs = new HashSet<int>();

        // check rows
        for (int i = 0; i < r; i++)
        {
            string[] currRow = matrix[i];
            allOccurs.Add(GetMaxOccurs(currRow));
        }

        // check cols
        for (int i = 0; i < c; i++)
        {
            string[] currRow = matrix.Select(row => row[i]).ToArray();
            allOccurs.Add(GetMaxOccurs(currRow));
        }

        // check first diagonals
        List<string> diagRow = new List<string>();

        for (int i = 0; i < r; i++)
        {
            for (int j = i; j > -1; j--)
            {
                string currElem = matrix[j][i - j];
                diagRow.Add(currElem);
            }

            allOccurs.Add(GetMaxOccurs(diagRow.ToArray()));

            diagRow.Clear();
        }

        for (int i = 1; i < r; i++)
        {
            for (int j = r - 1; j >= i; j--)
            {
                string currElem = matrix[j][i + r - 1 - j];
                diagRow.Add(currElem);
            }

            allOccurs.Add(GetMaxOccurs(diagRow.ToArray()));

            diagRow.Clear();
        }

        Console.WriteLine(allOccurs.Max());
    }

    private static int GetMaxOccurs(string[] arr)
    {

        return arr.Select((num, index) => new { Value = num, Index = index })
            .OrderBy(x => x.Value)
            .Select((n, i) => new { n.Value, Diff = i - n.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .Select(g => g.Count())
            .Max();
    }
}
