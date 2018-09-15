using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> mergedNums = new List<string>();
        List<string> squashedNums = new List<string>();

        string num = Console.ReadLine();
        while (--n > 0)
        {
            string prevNum = num;
            num = Console.ReadLine();

            mergedNums.Add(prevNum[1] + "" + num[0]);
            squashedNums.Add(prevNum[0] + $"{(char.GetNumericValue(prevNum[1]) + char.GetNumericValue(num[0])).ToString().Last()}" + num[1]);
        }

        Console.WriteLine(string.Join(" ", mergedNums));
        Console.WriteLine(string.Join(" ", squashedNums));
    }
}
