using System;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();

        int ballance = 0;
        foreach (char symb in expression)
        {
            if (symb == '(')
                ballance++;
            if (symb == ')')
                ballance--;

            if (ballance < 0)
            {
                Console.WriteLine("Incorrect");
                return;
            }
        }

        Console.WriteLine(ballance == 0 ? "Correct" : "Incorrect");
    }
}
