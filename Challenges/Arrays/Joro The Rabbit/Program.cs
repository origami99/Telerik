using System;
using System.Linq;

class JoroTheRabbit
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                int index = i;
                int len = 1;
                int next = default(int);

                while (next != i)
                {
                    next = index + j;

                    if (index + j >= nums.Length)
                        next -= nums.Length;

                    if (nums[index] >= nums[next])
                        break;

                    index = next;
                    len++;
                }

                if (len > result)
                    result = len;
            }
        }

        Console.WriteLine(result);
    }
}