using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> lenghts = new List<int>();
        int prevNum = 0;
        int currLenght = 1;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > prevNum)
            {
                currLenght++;
            }
            else
            {
                lenghts.Add(currLenght);
                currLenght = 1;
            }

            prevNum = num;
        }

        Console.WriteLine(lenghts.Max());
    }
}
