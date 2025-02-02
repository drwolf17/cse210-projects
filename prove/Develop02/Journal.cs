public class Journal
{

    public List<string> _prompts = new List<string>();
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine(entry._entry);
            Console.WriteLine("");
        }
    }

    public void Load(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split('~');
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            _entries.Add(entry);
        }
    }

    public void NewEntry()
    {
        Entry entry = new Entry();
        DateTime currentTime = DateTime.Now;

        entry._date = currentTime.ToShortDateString();
        entry._prompt = GeneratePrompt();

        Console.WriteLine(entry._prompt);
        entry._entry = Console.ReadLine();

        _entries.Add(entry);
    }

    public void Save(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.Write(entry._date + "~");
                outputFile.Write(entry._prompt + "~");
                outputFile.Write(entry._entry);
                outputFile.WriteLine("");
            }
        }
    }

    public string GeneratePrompt()
    {
        Random randomGen = new Random();
        
        int promptNumber = randomGen.Next(0, _prompts.Count);
        string prompt = _prompts[promptNumber];

        return prompt;
    }
}