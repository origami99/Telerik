using System;

class Program
{
    private static int[] iterVariables;

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        iterVariables = new int[k];

        PrintCombinations(n, k);
    }

    private static void PrintCombinations(int n, int k, int start = 1)
    {
        if (k == 0)
        {
            Console.WriteLine(string.Join(" ", iterVariables));
            return;
        }

        for (int i = start; i <= n; i++)
        {
            iterVariables[iterVariables.Length - k] = i;
            PrintCombinations(n, k - 1, i + 1);
        }
    }
}