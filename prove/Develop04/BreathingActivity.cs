using System.Diagnostics;
/* This class runs the breathing activity using both itself and the parent class. */
public class RJBreathingActivity : RJActivity
{
    private int _RJinTime;
    private int _RJoutTime;

    public RJBreathingActivity(string RJactivityName, string RJintroMessage) : base(RJactivityName, RJintroMessage)
    {
        /* Set member variables. */
        _RJinTime = 4;
        _RJoutTime = 6;
    }
    
    public void RJBreathe()
    {
        /* Run through the activity for as long as the durration states. */
        RJStartActivity();

        DateTime RJcurrentTime = DateTime.Now;
        DateTime RJendTime = RJcurrentTime.AddSeconds(_RJdurration);

        while (RJcurrentTime < RJendTime)
        {
            Console.Write($"Breathe in... ");
            RJShowCountdown(_RJinTime);
            Console.WriteLine();

            Console.Write($"Now breathe out... ");
            RJShowCountdown(_RJoutTime);
            Console.WriteLine();
            Console.WriteLine();
            RJcurrentTime = DateTime.Now;
        }

        RJEndActivity();
    }
}