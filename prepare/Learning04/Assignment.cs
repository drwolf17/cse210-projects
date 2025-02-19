public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        name = _studentName;
        topic = _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}