using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment newA = new Assignment("rychen", "Math");
        Console.WriteLine(newA.GetSummary());

        MathAssignment newMA = new MathAssignment("rychen", "Math", "section", "problems");
        Console.WriteLine(newMA.GetHomeworkList());

        WritingAssignment newWA = new WritingAssignment("rychen", "Math", "The Hunger Games");
        Console.WriteLine(newWA.GetWritingInformation());

    }
}