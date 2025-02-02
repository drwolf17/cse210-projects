class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        DateTime currentTime = DateTime.Now;


        journal._prompts.Add("Prompt Test1");
        journal._prompts.Add("Prompt Test2");
        journal._prompts.Add("Prompt Test3");
        journal._prompts.Add("Prompt Test4");
        journal._prompts.Add("Prompt Test5");
        journal._prompts.Add("Prompt Test6");
        journal._prompts.Add("Prompt Test7");
        journal._prompts.Add("Prompt Test8");

        string prompt = journal.GeneratePrompt();

        journal.NewEntry(prompt);

        // prompt = journal.GeneratePrompt();

        // journal.NewEntry(prompt);

        journal.Display();

        Console.WriteLine("Saving Test");
        journal.Save("test.txt");

        Console.WriteLine("Loading Test");
        journal.Load("test.txt");

        journal.Display();

    }
}