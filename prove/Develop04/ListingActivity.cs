using System.Runtime.InteropServices;
/* This class runs the listing activity using both itself and the parent class. */
public class RJListingActivity : RJActivity
{
    private List<string> _RJpromptList = new List<string>();

    public RJListingActivity(string RJactivityName, string RJintroMessage) : base(RJactivityName, RJintroMessage)
    {
        /* Set member variables. */
        _RJpromptList.Add("Who are people that you appreciate?");
        _RJpromptList.Add("What are personal strengths of yours?");
        _RJpromptList.Add("Who are people that you have helped this week?");
        _RJpromptList.Add("When have you felt the Holy Ghost this month?");
        _RJpromptList.Add("Who are some of your personal heroes?");
    }

    public string RJGetRandomPrompt()
    {
        /* Return a random item from the prompt list. */
        Random RJrand = new Random();
        string RJprompt = _RJpromptList[RJrand.Next(_RJpromptList.Count())];
        return RJprompt;
    }

    public void RJList()
    {
        /* Run through the activity for as long as the durration states. */
        string RJprompt = RJGetRandomPrompt();

        RJStartActivity();

        DateTime RJcurrentTime = DateTime.Now;
        DateTime RJendTime = RJcurrentTime.AddSeconds(_RJdurration);

        int RJcount = 0;
        while (RJcurrentTime < RJendTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            RJcount++;
            RJcurrentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {RJcount} itemns!");

        Console.WriteLine();
        RJEndActivity();
    }
}