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
            int elemsInDiagCount = i + 1;
            if (elemsInDiagCount > c) { elemsInDiagCount = c; }
            for (int j = 0; j < elemsInDiagCount; j++)
            {
                string currElem = matrix[r - 1 - i + j][j];
                diagRow.Add(currElem);
            }

            allOccurs.Add(GetMaxOccurs(diagRow.ToArray()));
            diagRow.Clear();
        }
        for (int i = 0; i < c - 1; i++)
        {
            int elemsInDiagCount = c - i - 1;
            if (elemsInDiagCount > r) { elemsInDiagCount = r; }
            for (int j = 0; j < elemsInDiagCount; j++)
            {
                string currElem = matrix[j][j + i + 1];
                diagRow.Add(currElem);
            }

            allOccurs.Add(GetMaxOccurs(diagRow.ToArray()));
            diagRow.Clear();
        }

        // check second diagonals
        for (int i = 0; i < c; i++)
        {
            int elemsInDiagCount = i + 1;
            if (elemsInDiagCount > r) { elemsInDiagCount = r; }
            for (int j = 0; j < elemsInDiagCount; j++)
            {
                string currElem = matrix[j][i - j];
                diagRow.Add(currElem);
            }

            allOccurs.Add(GetMaxOccurs(diagRow.ToArray()));
            diagRow.Clear();
        }
        for (int i = 0; i < r - 1; i++)
        {
            int elemsInDiagCount = r - i - 1;
            if (elemsInDiagCount > c) { elemsInDiagCount = c; }
            for (int j = 0; j < elemsInDiagCount; j++)
            {
                string currElem = matrix[j + i + 1][c - j - 1];
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
