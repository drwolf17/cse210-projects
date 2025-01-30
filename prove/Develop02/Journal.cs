public class Journal
{
    public string _entryLogFile;
    public List<string> _prompts = new List<string>();
    public void DisplayTest()
    {
        Console.WriteLine(_entryLogFile);
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}