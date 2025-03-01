public class Mindfulness 
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Mindfulness(string activity, string description)
    {
        _activityName = activity;
        _description = description;
        _duration = 0;
    }

    public void GenericGreeting()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine("");

        Console.WriteLine(_description);
        Console.WriteLine("");
    }

    public void DurationPrompt()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void WaitAnimtion(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("x");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void GenericEnding()
    {
        Console.WriteLine("Well Done!");
        WaitAnimtion(5);
        Console.WriteLine("");

        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} activity.");
        WaitAnimtion(5);
    }
}