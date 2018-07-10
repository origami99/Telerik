using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string result = input + new string('*', 20 - input.Length);

        Console.WriteLine(result);
    }
}
