using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static void PromptUserName(out string name)
    {
        Console.Write("What is your name?: ");
        name = Console.ReadLine();
    }
    static void PromptUserNumber(out int number)
    {
        Console.Write("What is your favorite number?: ");
        number = int.Parse(Console.ReadLine());
    }
    static void PromtUserBirthYear(out int year)
    {
        Console.Write("What is your birthyear?: ");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, your number squared is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name;
        PromptUserName(out user_name);
        int user_number;
        PromptUserNumber(out user_number);
        int user_birthyear;
        PromtUserBirthYear(out user_birthyear);
        int square = SquareNumber(user_number);
        DisplayResult(user_name, square, user_birthyear);
    }
}