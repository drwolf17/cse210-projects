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

        Console.WriteLine("");
    }

    public override string SaveGoal()
    {
        string attributes =
        
            "ChecklistGoal" + "~" +
            _goalTitle + "~" +
            _goalDesc + "~" +
            _goalValue.ToString() + "~" +
            _goalBonus.ToString() + "~" +
            _timesCompleted.ToString() + "~" +
            _goalEnd.ToString();
        

        return attributes;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted > _goalEnd)
        {
            _timesCompleted--;

            Console.WriteLine("This goal has already been completed");

            return 0;
        }

        else if (_timesCompleted == _goalEnd)
        {
            return _goalValue + _goalBonus;
        }

        else
        {
            return _goalValue;
        }
    }
}