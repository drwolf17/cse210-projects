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
    // for each goal and it will get a create a long string of all the attributes needed
    // to create the class without having to check what the type of goal is when
    // loading from a file.
    public abstract string SaveGoal();

    public abstract int RecordEvent();
}