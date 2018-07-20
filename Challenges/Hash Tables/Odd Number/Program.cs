using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, bool> oddOccurs = new Dictionary<string, bool>();

        for (int i = 0; i < n; i++)
        {
            string num = Console.ReadLine();

            if (!oddOccurs.ContainsKey(num))
                oddOccurs[num] = true;
            else
                oddOccurs[num] = !oddOccurs[num];
        }

        Console.WriteLine(oddOccurs.Single(x => x.Value == true).Key);
    }
}
