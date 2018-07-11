using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

        int days = Math.Abs((firstDate - secondDate).Days);
        Console.WriteLine($"Distance: {days} days");
    }
}
