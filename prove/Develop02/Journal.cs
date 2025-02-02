using System.IO;

public class Journal
{
    public string _userFile;
    public List<string> _prompts = new List<string>();
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine(entry._entry);
        }
    }

    // public void Display()
    // {
    //     string[] lines = System.IO.File.ReadAllLines(_entryLogFile);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split('~');
    //         Console.WriteLine($"Date: {parts[0]} - Prompt: {parts[1]}");
    //         Console.WriteLine(parts[2]);
    //     }
    // }

    public void NewEntry(string prompt)
    {
        Entry entry = new Entry();
        DateTime currentTime = DateTime.Now;

        entry._date = currentTime.ToShortDateString();
        entry._prompt = prompt;

        Console.WriteLine(entry._prompt);
        entry._entry = Console.ReadLine();

        _entries.Add(entry);
        

        // using (StreamWriter outputFile = new StreamWriter(_entryLogFile))
        // {

        //     outputFile.Write(entry._date + "~");
        //     outputFile.Write(entry._prompt + "~");
        //     outputFile.Write(entry._entry);
        //     outputFile.WriteLine("");

        // }
    }

    public string GeneratePrompt()
    {
        Random randomGen = new Random();
        
        int promptNumber = randomGen.Next(0, _prompts.Count);
        string prompt = _prompts[promptNumber];

        return prompt;
    }
}