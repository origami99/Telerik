using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // start - 10:20

        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        int[] nums = new int[n].Select(x => x = int.Parse(Console.ReadLine())).ToArray();

        int bestCounter = 0;
        int counter = 1;
        for (int i = 1; i < n; i++)
        {
            if (nums[i] == nums[i - 1])
                counter++;
            else
                counter = 1;

            if (counter > bestCounter)
                bestCounter = counter;
        }

        Console.WriteLine(bestCounter);

        // end - 10:24
    }
}
