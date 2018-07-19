using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();

        str = new string(str.ToCharArray().Reverse().ToArray());

        Console.WriteLine(str);
    }
}
