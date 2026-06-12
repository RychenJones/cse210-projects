using System;
using System.Security.Cryptography.X509Certificates;
/* 
Name: Rychen Jones
Date: 6/12/26
Sources:
    Class documentation: https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
    W3 Schools

Creativity: The program tracks and displays the amount of times each activity is performed.
*/
class Program
{
    static void Main(string[] args)
    {
        /* Run the program as long as "quit" is not selected. */
        string RJselection = "";
        int RJbreatheCount = 0;
        int RJreflectCount = 0;
        int RJlistCount = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            RJselection = Console.ReadLine();
            
            if (RJselection == "1")
            {
                RJBreathingActivity RJbreathe = new RJBreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                RJbreathe.RJBreathe();

                RJbreatheCount++;
            }
            else if (RJselection == "2")
            {
                RJReflectionActivity RJreflect = new RJReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                RJreflect.RJReflect();

                RJreflectCount++;
            }
            else if (RJselection == "3")
            {
                RJListingActivity RJlist = new RJListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                RJlist.RJList();

                RJlistCount++;
            }
            else if (RJselection != "4")
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
        while (RJselection != "4");
        Console.WriteLine("Thanks for using the the program!");
        Console.WriteLine("Activity completions:");
        Console.WriteLine($"\tBreathing activity: {RJbreatheCount}");
        Console.WriteLine($"\tReflecting activity: {RJreflectCount}");
        Console.WriteLine($"\tListing activity: {RJlistCount}");
    }
}