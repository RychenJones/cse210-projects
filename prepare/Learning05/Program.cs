using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square newSqare = new Square("red", 5);
        double area = newSqare.GetArea();
        Console.WriteLine(area);

        Rectangle newRec = new Rectangle("red", 5, 2);
        double area2 = newRec.GetArea();
        Console.WriteLine(area2);

        Circle newCircle = new Circle("red", 5);
        double area3 = newCircle.GetArea();
        Console.WriteLine(area3);
    }
}