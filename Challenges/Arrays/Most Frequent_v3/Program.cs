using System;

class Program
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        short[] nums = new short[n];
        for (short i = 0; i < n; i++)
        {
            nums[i] = short.Parse(Console.ReadLine());
        }

        BubbleSort(ref nums);

        short maxOccurs, bestNum;
        FindMostOccurs(nums, out maxOccurs, out bestNum);

        Console.WriteLine($"{bestNum} ({maxOccurs} times)");
    }

    private static void BubbleSort(ref short[] arr)
    {
        short temp;
        for (short i = 0; i <= arr.Length - 2; i++)
        {
            for (short j = 0; j <= arr.Length - 2; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    private static void FindMostOccurs(short[] nums, out short maxOccurs, out short bestNum)
    {
        maxOccurs = 0;
        short currOccurs = 1;
        bestNum = 0;
        for (short i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                currOccurs++;
            }
            else
            {
                currOccurs = 1;
            }

            if (currOccurs > maxOccurs)
            {
                maxOccurs = currOccurs;
                bestNum = nums[i];
            }
        }
    }
}
