using System.Diagnostics.CodeAnalysis;
/* This class runs the reflection activity using both itself and the parent class. */

public class RJReflectionActivity : RJActivity
{
    private List<string> _RJpromptList = new List<string>();
    private List<string> _RJquestionList = new List<string>();

    public RJReflectionActivity(string RJactivityName, string RJintroMessage) : base(RJactivityName, RJintroMessage)
    {
        /* Set member variables. */
        _RJpromptList.Add("Think of a time when you stood up for someone else.");
        _RJpromptList.Add("Think of a time when you did something really difficult.");
        _RJpromptList.Add("Think of a time when you helped someone in need.");
        _RJpromptList.Add("Think of a time when you did something truly selfless.");

        _RJquestionList.Add("Why was this experience meaningful to you?");
        _RJquestionList.Add("Have you ever done anything like this before?");
        _RJquestionList.Add("How did you get started?");
        _RJquestionList.Add("How did you feel when it was complete?");
        _RJquestionList.Add("What made this time different than other times when you were not as successful?");
        _RJquestionList.Add("What is your favorite thing about this experience?");
        _RJquestionList.Add("What could you learn from this experience that applies to other situations?");
        _RJquestionList.Add("What did you learn about yourself through this experience?");
        _RJquestionList.Add("How can you keep this experience in mind in the future?");
    }

    public string RJGetRandomListItem(List<string> RJlist)
    { 
        /* Return a random item from the list that was passing in. */
        Random RJrand = new Random();
        string RJprompt = RJlist[RJrand.Next(RJlist.Count())];
        return RJprompt;
    }

    public void RJReflect()
    {
        /* Run through the activity for as long as the durration states. */
        string RJprompt = RJGetRandomListItem(_RJpromptList);
        
        RJStartActivity();

        DateTime RJcurrentTime = DateTime.Now;
        DateTime RJendTime = RJcurrentTime.AddSeconds(_RJdurration);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {RJprompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:  ");
        RJShowCountdown(5);

        Console.Clear();

        while (RJcurrentTime < RJendTime)
        {
            string RJquestion = RJGetRandomListItem(_RJquestionList);
            Console.Write($">  {RJquestion}  ");
            RJShowWaitingSymbol(2);

            RJcurrentTime = DateTime.Now;
        }
        
        Console.WriteLine();
        RJEndActivity();
    }
}