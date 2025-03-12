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
}