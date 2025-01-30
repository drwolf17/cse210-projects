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

    public void NewEntry(string prompt)
    {
        Entry entry = new Entry();
        DateTime currentTime = DateTime.Now;

        entry._date = currentTime.ToShortDateString();
        entry._prompt = prompt;

        Console.WriteLine(entry._prompt);
        entry._entry = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_entryLogFile))
        {
            outputFile.Write(entry._date + "~");
            outputFile.Write(entry._prompt + "~");
            outputFile.Write(entry._entry);
        }
    }
}