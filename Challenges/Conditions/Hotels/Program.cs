using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] lenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int startHotels = 0;
        int endHotels = 0;

        int bestStartLen = int.MinValue;
        int bestEndLen = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            if (lenghts[i] > bestStartLen)
            {
                bestStartLen = lenghts[i];
                startHotels++;
            }

            if (lenghts[n - i - 1] > bestEndLen)
            {
                bestEndLen = lenghts[n - i - 1];
                endHotels++;
            }
        }

        Console.WriteLine($"{startHotels} {endHotels}");
    }
}