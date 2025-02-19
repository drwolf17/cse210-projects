public class WritingAssignemnt : Assignment
{
    private string _title;

    public WritingAssignemnt(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return _title + " by " + _studentName;
    }
}