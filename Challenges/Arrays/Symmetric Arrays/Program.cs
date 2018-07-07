using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(IsSymmetric(nums) ? "Yes" : "No");
        }
    }

    private static bool IsSymmetric(int[] nums)
    {
        for (int i = 0; i < nums.Length / 2; i++)
        {
            int leftElem = nums[i];
            int rightElem = nums[nums.Length - i - 1];

            if (leftElem != rightElem)
            {
                return false;
            }
        }

        return true;
    }
}
