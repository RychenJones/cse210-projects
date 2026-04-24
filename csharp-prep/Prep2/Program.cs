using System;
using System.ComponentModel;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade Point Average: ");
        string response = Console.ReadLine();
        int gpa = int.Parse(response);
        string letter = "";
        bool pass = false;

        if (gpa >= 90)
        {
            letter = "A";
            pass = true;
        }
        else if (gpa >= 80)
        {
            letter = "B";
            pass = true;
        }
        else if (gpa >= 70)
        {
            letter = "C";
            pass = true;
        }
        else if (gpa >= 60)
        {
            letter = "D";
            pass = false;
        }
        else
        {
            letter = "F";
            pass = false;
        }
        Console.WriteLine($"You got an {letter}.");
        if (pass == true)
        {
            Console.WriteLine($"You passed!");
        }
        else
        {
            Console.WriteLine($"You failed");
        }
    }
}