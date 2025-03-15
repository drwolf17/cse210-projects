public abstract class Goals
{
    protected string _goalTitle;
    protected string _goalDesc;
    protected int _goalValue;

    public Goals(string goalTitle, string goalDesc, int goalValue)
    {
        _goalTitle = goalTitle;
        _goalDesc = goalDesc;
        _goalValue = goalValue;
    }

    public abstract void DisplayGoal();

    // This exists for when saving classes it can just call this method
    // for each goal and it will get a list of each of the attributes needed
    // to create the class without having to check what the type of goal is
    public abstract List<string> ListAttributes();

    public abstract int RecordEvent();
}