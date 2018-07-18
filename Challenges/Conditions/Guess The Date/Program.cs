using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        DateTime prevDay = new DateTime(year, month, day).AddDays(-1);

        Console.WriteLine(prevDay.ToString("d-MMM-yyyy", CultureInfo.InvariantCulture));
    }
}
