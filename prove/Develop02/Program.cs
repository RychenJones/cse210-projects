/* 
Name: Rychen Jones
Date: 5/15/26
Sources:
    Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*/

using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        // create journal instance.
        RJJournal rjNewJournal = new RJJournal();

        // set sentinel
        int rjSelection = 0;

        // loop user input and response. Continue until 5 is inputed.
        while (rjSelection != 5)
        {
            // welcome and display the menu.
            Console.WriteLine("Welcome to the journal program.");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Display the journal");
            Console.WriteLine("3 - Save the journal to a file");
            Console.WriteLine("4 - Load the journal from a file");
            Console.WriteLine("5 - Quit");
            Console.Write("Choice: ");

            // get the user's choice and turn it into an int.
            string rjChoice = Console.ReadLine();
            rjSelection = int.Parse(rjChoice);

            // run logic based on the user's selection.
            if (rjSelection == 1)
            {
                // write new entry
                RJEntry rjNewEntry = new RJEntry();

                Console.Write("Date (mm/dd/yy): ");
                string rjDate = Console.ReadLine();
                rjNewEntry._rjDate = rjDate;

                Console.Write("Today's mood: ");
                string rjMood = Console.ReadLine();
                rjNewEntry._rjMood = rjMood;

                rjNewEntry._rjPrompt = GeneratePrompt();

                Console.WriteLine(rjNewEntry._rjPrompt);
                Console.Write(">");
                string rjEntryText = Console.ReadLine();
                rjNewEntry._rjEntryText = rjEntryText;

                rjNewJournal._rjEntries.Add(rjNewEntry);
            }
            else if (rjSelection == 2)
            {
                // display entries
                rjNewJournal.RJDisplayEntries();
            }
            else if (rjSelection == 3)
            {
                // save journal to file
                Console.WriteLine("What is the name of the file you would like to save to?: ");
                Console.Write(">");
                string filename = Console.ReadLine();

                rjNewJournal.RJSaveJournal(filename);            
            }
            else if (rjSelection == 4)
            {
                // load jornal from file
                Console.WriteLine("What is the name of the file you would like to load from?: ");
                Console.Write(">");
                string filename = Console.ReadLine();

                rjNewJournal.RJLoadJournal(filename);
            }
            else if (rjSelection == 5)
            {
                // exit
                Console.WriteLine("Thanks for using the program.");
            }
            else
            {
                // handle case of incorrect input
                Console.WriteLine("Input between 1-5 required.");
            }
        }
    }
    

    // select and return a random prompt from the provided list
    static string GeneratePrompt()
    {   
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What moment today made me stop and think for a second?",
            "When did I feel the most motivated or energized today?",
            "What challenge did I handle better than I would have a year ago?",
            "What small detail from today do I want to remember a month from now?",
            "Did I act like the kind of person I want to become today?"
        };

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];

        return prompt;
    }
}