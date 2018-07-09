using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();

        foreach (char symb in word)
        {
            Console.WriteLine(symb - 'a' + 1);
        }
    }
}
