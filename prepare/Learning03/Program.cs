using System;
using System.Security.Cryptography;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");   
        Fraction newFraction1 = new Fraction();
        Console.WriteLine(newFraction1.GetFractionString());
        Console.WriteLine(newFraction1.GetDecimalValue());

        Console.WriteLine("Hello Learning03 World!");   
        Fraction newFraction2 = new Fraction(5);
        Console.WriteLine(newFraction2.GetFractionString());
        Console.WriteLine(newFraction2.GetDecimalValue());

        Console.WriteLine("Hello Learning03 World!");   
        Fraction newFraction3 = new Fraction(3,4);
        Console.WriteLine(newFraction3.GetFractionString());
        Console.WriteLine(newFraction3.GetDecimalValue());

        Console.WriteLine("Hello Learning03 World!");   
        Fraction newFraction4 = new Fraction(1, 3);
        Console.WriteLine(newFraction4.GetFractionString());
        Console.WriteLine(newFraction4.GetDecimalValue());

        Random ran = new Random();
        Fraction newFraction5 = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            int top = ran.Next(1, 11);
            int bottom = ran.Next(1, 11);
            newFraction5.SetTop(top);
            newFraction5.SetBottom(bottom);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"String: {newFraction5.GetFractionString()}\t\t");
            Console.WriteLine($"Decimal: {newFraction5.GetDecimalValue()}");
        }
    }
}