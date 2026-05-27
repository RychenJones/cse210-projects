using System;
using System.ComponentModel.DataAnnotations;

/* 
Name: Rychen Jones
Date: 5/26/26
Sources:
    Class documentation: https://byui-cse.github.io/cse210-course-2023/unit03/develop.html
    W3 Schools
    Microsoft Learning
    Stack Overflow
*/

class Program
{
    static void Main(string[] args)
    {
        string RJbook = "Proverbs";
        int RJchapter = 3;
        int[] RJverses = [5, 6];
        string RJverseText = "Trust in the Lord more words to give a chance to test ha ha";
        string RJinput = "";

        RJScripture RJnewScripture = new RJScripture(RJverseText);
        RJReference RJnewReference = new RJReference(RJbook, RJchapter, RJverses.First());
        if (RJverses.Count() > 1)
        {
            RJnewReference = new RJReference(RJbook, RJchapter, RJverses.First(), RJverses.Last());
        }
        
        Console.Clear();
        Console.WriteLine("Welcome to the program.");
        Console.WriteLine();
        do
        {
            Console.WriteLine("Here is the verse:");
            Console.WriteLine(RJnewReference.RJReturnReference());
            Console.WriteLine(RJnewScripture.RJReturnVerse());

            if (RJnewScripture.RJgetNumberHidden() == RJnewScripture.RJgetListLength())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or push 'q' to quit.");

            Console.Write(">");
            RJinput = Console.ReadLine();
            
            if (RJinput == "")
            {
                RJnewScripture.RJHideWords();
                Console.Clear();
            }
            else if (RJinput != "q")
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid input.");
            }
        }
        while (RJinput != "q");
    }
}