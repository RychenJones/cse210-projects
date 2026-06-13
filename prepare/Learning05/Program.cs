using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> list = new List<Shape>();

        Square newSqare = new Square("red", 5);
        list.Add(newSqare);

        // double area = newSqare.GetArea();
        // Console.WriteLine(area);

        Rectangle newRec = new Rectangle("red", 5, 2);
        list.Add(newRec);
        // double area2 = newRec.GetArea();
        // Console.WriteLine(area2);

        Circle newCircle = new Circle("red", 5);
        list.Add(newCircle);
        // double area3 = newCircle.GetArea();
        // Console.WriteLine(area3);
        foreach (Shape i in list)
        {
            double area = i.GetArea();
            string color = i.GetColor();
            Console.WriteLine($"{area}, {color}");
        }
    }
}