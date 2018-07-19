using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] firstArr = new string[n];
        string[] secondArr = new string[n];

        FillArr(n, firstArr);
        FillArr(n, secondArr);

        bool areEqual = true;
        for (int i = 0; i < n; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine(areEqual ? "Equal" : "Not equal");
    }

    private static void FillArr(int n, string[] firstArr)
    {
        for (int i = 0; i < n; i++)
        {
            firstArr[i] = Console.ReadLine();
        }
    }
}
