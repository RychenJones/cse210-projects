using System.Diagnostics;
/* 
This class holds member variables and attributes that are all applicable and used by every child class.
 */
public class RJActivity 
{
    private string _RJintro;
    protected int _RJdurration;
    private string _RJactivityName;    
    private string _RJintroMessage;

    public RJActivity(string RJactivityName, string RJintroMessage)
    {
        /* Set member variables */
        _RJintro = $"Welcome to the {RJactivityName}.";
        _RJdurration = 0;
        _RJactivityName = RJactivityName;
        _RJintroMessage = RJintroMessage;
    }

    public int RJComputeTime()
    {
        /* Compute milliseconds from the user-entered duration in seconds. */
        return _RJdurration * 1000;
    }

    public void RJShowWaitingSymbol(int reps)
    {
        /* Iterate through the list of characters to show a waiting symbol for as many repetitions as are passed in. */
        string[] RJsymbolBank = {"|", "/", "-", """\""", "|", "/", "-", """\"""};
        for (int rep = 0; rep < reps; rep++)
            for (int i = 0; i < RJsymbolBank.Length; i++)
            {
                Console.Write("\b");
                Console.Write(RJsymbolBank[i]);
                Thread.Sleep(300);
            }
        Console.Write("\b");
        Console.Write(" ");
        Console.WriteLine();
    }
    
    public void RJShowCountdown(int seconds)
    {
        /* Show a countdown for as many seconds as are passed in. */
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.Write("\b");
        Console.Write(" ");
    }
    public void RJShowWelcomeMessage()
    {
        /* Show a welcome message tailored to each activity. */
        Console.WriteLine(_RJintro);
        Console.WriteLine();
        Console.WriteLine(_RJintroMessage);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _RJdurration = int.Parse(Console.ReadLine());
    }
    public void RJShowGoodbyeMessage()
    {
        /* Show a goodbye message tailored to each activity. */
        Console.WriteLine($"You have completed another {_RJdurration} seconds of the {_RJactivityName}.");
    }

    public void RJStartActivity()
    {
        /* Call ShowWelcomeMessage and the get ready countdown. */
        Console.Clear();
        RJShowWelcomeMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        RJShowWaitingSymbol(1);
    }

    public void RJEndActivity()
    {
        /* Give a message and call ShowGoodbyeMessage. Show appropriate waiting symbols between actions. */
        Console.WriteLine("Well done!");
        RJShowWaitingSymbol(1);
        RJShowGoodbyeMessage();
        RJShowWaitingSymbol(1);
    }
}