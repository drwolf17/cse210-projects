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
}