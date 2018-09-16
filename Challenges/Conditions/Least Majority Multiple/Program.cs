using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> nums = new List<int>();

        for (int i = 0; i < 5; i++)
            nums.Add(int.Parse(Console.ReadLine()));

        for (int i = 1; ; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Count; j++)
            {
                if (i % nums[j] == 0)
                    count++;

                if (count >= 3)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
