using System;

class Program
{
    static void Main()
    {
        try
        {
            decimal num = decimal.Parse(Console.ReadLine());

            decimal sqrt = (decimal)Math.Sqrt((double)num);

            Console.WriteLine($"{sqrt:F3}");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
