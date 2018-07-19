using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        foreach (var symb in text)
        {
            Console.Write($@"\u{(int)symb:x4}");
        }
        Console.WriteLine();
    }
}
