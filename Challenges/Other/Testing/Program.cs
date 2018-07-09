using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine().Split().Select(x => int.Parse(x));
        Console.WriteLine(nums.Min() + nums.Max());
    }
}
