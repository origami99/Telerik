using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int start = int.Parse(input[0]);
        int end = int.Parse(input[1]);

        // I know, it's not cool. It was just for the challenge ;) 
        int goodCount = Enumerable.Range(start, end - start + 1)
            .Count(num => !num.ToString().Where(digit => digit != '0').Where(digit => num % char.GetNumericValue(digit) != 0).Any());

        Console.WriteLine(goodCount);
    }
}
