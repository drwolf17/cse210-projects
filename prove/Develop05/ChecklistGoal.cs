public class ChecklistGoal : Goals
{
    private int _goalBonus;
    private int _timesCompleted;
    private int _goalEnd;

    public ChecklistGoal(string goalTitle, string goalDesc, int goalValue, int goalBonus, int timesCompleted, int goalEnd) : base(goalTitle, goalDesc, goalValue)
    {
        _goalBonus = goalBonus;
        _timesCompleted = timesCompleted;
        _goalEnd = goalEnd;
    }

    public override void DisplayGoal()
    {
        if (_timesCompleted >= _goalEnd)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write($"[{_timesCompleted}/{_goalEnd}] ");
        }
        Console.Write($"{_goalTitle} ");
        Console.Write($"({_goalDesc})");
    }

    public override List<string> ListAttributes()
    {
        List<string> attributes =
        [
            "ChecklistGoal",
            _goalTitle,
            _goalDesc,
            _goalValue.ToString(),
            _timesCompleted.ToString(),
            _goalEnd.ToString()
        ];

        return attributes;
    }
}