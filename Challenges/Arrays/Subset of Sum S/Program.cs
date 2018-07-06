using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        bool[,] solution = new bool[nums.Length + 1, sum + 1];

        for (int i = 1; i <= sum; i++)
        {
            solution[0, i] = false;
        }

        for (int i = 0; i <= nums.Length; i++)
        {
            solution[i, 0] = true;
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            for (int j = 1; j <= sum; j++)
            {
                solution[i, j] = solution[i - 1, j];

                if (solution[i, j] == false && j >= nums[i - 1])
                {
                    solution[i, j] = solution[i, j] || solution[i - 1, j - nums[i - 1]];
                }
            }
        }

        bool containsSum = solution[nums.Length, sum];

        Console.WriteLine(containsSum ? "yes" : "no");
    }
}
