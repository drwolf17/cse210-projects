using System.IO;

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
    public void Display()
    {
        string[] lines = System.IO.File.ReadAllLines(_entryLogFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            Console.WriteLine($"Date: {parts[0]} - Prompt: {parts[1]}");
            Console.WriteLine(parts[2]);
        }
    }
}