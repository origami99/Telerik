using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split();

        array = array.Reverse().ToArray();

        Console.WriteLine(string.Join(", ", array));
    }
}
