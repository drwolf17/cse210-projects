public class SimpleGoal : Goals
{
    private bool _goalCompleted;

    public SimpleGoal(string goalTitle, string goalDesc, int goalValue, bool goalCompleted) : base(goalTitle, goalDesc, goalValue)
    {
        _goalCompleted = goalCompleted;
    }

    public override void DisplayGoal()
    {
        if (_goalCompleted)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.Write($"{_goalTitle} ");
        Console.Write($"({_goalDesc})");

        Console.WriteLine("");
    }

    public override string SaveGoal()
    {
        string attributes =
        
            "SimpleGoal" + "~" +
            _goalTitle + "~" +
            _goalDesc + "~" +
            _goalValue.ToString() + "~" +
            _goalCompleted.ToString();

        return attributes;
    }

    public override int RecordEvent()
    {
        if (_goalCompleted)
        {
            Console.WriteLine("You have already completed this goal.");

            return 0;
        }

        else
        {
            _goalCompleted = true;

            return _goalValue;
        }
    }
}