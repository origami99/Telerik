using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(',');
        HashSet<string> set = new HashSet<string>(nums);
        List<string> result = new List<string>();

        for (int i = 1; i <= nums.Length; i++)
            if (!set.Contains(i.ToString()))
                result.Add(i.ToString());

        Console.WriteLine(string.Join(",", result));
    }
}
