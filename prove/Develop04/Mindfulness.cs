public class Mindfulness 
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected int _loops;

    public Mindfulness(string activity, string description)
    {
        _activityName = activity;
        _description = description;
        _duration = 0;
        _loops = 0;
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
        for (int i = 0; i < duration * 2; i++)
        {
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("x");
            Thread.Sleep(250);
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

    public string RandomString(List<string> stringList)
    {
        Random rand = new Random();

        int item = rand.Next(0, stringList.Count());
        string randomString = stringList[item];

        return randomString;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        WaitAnimtion(5);
    }

    public void Countdown(int duration)
    {
        for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}