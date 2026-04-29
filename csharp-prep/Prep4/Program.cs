using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int UserInput = 0;
        do
        {
            Console.Write("""Input a number to insert into the list (press "0" to stop): """);
            UserInput = int.Parse(Console.ReadLine());
            if (UserInput != 0)
            {
                numbers.Add(UserInput);
            }
        } while (UserInput != 0);

        int sum = 0;
        int max = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        float avg = (float)sum / numbers.Count();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The highest number is {max}");
    }
}