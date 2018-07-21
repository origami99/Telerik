using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.ReadLine();
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] sortedArr = arr.OrderBy(x => -x).ToArray();
        Console.WriteLine(string.Join(" ", arr.Select(x => x = Array.IndexOf(sortedArr, x) + 1)));
    }
}
