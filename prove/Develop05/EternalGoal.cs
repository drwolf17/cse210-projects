public class EternalGoal : Goals
{
    private int _timesCompleted;

    public EternalGoal(string goalTitle, string goalDesc, int goalValue, int timesCompleted) : base(goalTitle, goalDesc, goalValue)
    {
        _timesCompleted = timesCompleted;
    }

    public override void DisplayGoal()
    {
        Console.Write($"[{_timesCompleted}] ");
        Console.Write($"{_goalTitle} ");
        Console.Write($"({_goalDesc})");

        Console.WriteLine("");
    }
    
    public override List<string> ListAttributes()
    {
        List<string> attributes =
        [
            "EternalGoal",
            _goalTitle,
            _goalDesc,
            _goalValue.ToString(),
            _timesCompleted.ToString(),
        ];

        return attributes;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        return _goalValue;
    }
}