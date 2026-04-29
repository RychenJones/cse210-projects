using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess = 0;

        do
        {
        Console.Write("Guess the magic number: ");
        guess = int.Parse(Console.ReadLine());
        if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);

    }
}