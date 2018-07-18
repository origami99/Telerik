using System;
using System.Linq;

public class Program
{
    private static int[] nums;
    private static int bestSum = 0;

    public static void Main()
    {
        ReadInput();
        SetBestSum();
        PrintBestSum();
    }

    private static void ReadInput()
    {
        int n = int.Parse(Console.ReadLine());
        nums = new int[n].Select(x => int.Parse(Console.ReadLine())).ToArray();
    }

    static void SetBestSum()
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (sum <= 0)
                sum = 0;

            sum += nums[i];

            if (sum > bestSum)
                bestSum = sum;
        }
    }

    private static void PrintBestSum() =>
        Console.WriteLine(bestSum);
}
