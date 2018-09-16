using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine();

        HashSet<int> studentsNoPens = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
        HashSet<int> studentsWithSparePen = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));

        int count = 0;

        foreach (int student in studentsNoPens)
        {
            if (studentsWithSparePen.Contains(student - 1))
            {
                studentsWithSparePen.Remove(student - 1);
                count++;
            }
            else if (studentsWithSparePen.Contains(student + 1))
            {
                studentsWithSparePen.Remove(student + 1);
                count++;
            }
        }

        Console.WriteLine(studentsNoPens.Count - count);
    }
}