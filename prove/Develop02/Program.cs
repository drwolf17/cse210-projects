using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        DateTime currentTime = DateTime.Now;

        entry._prompt = "prompt test";
        entry._date = currentTime.ToShortDateString() + " test";
        entry._entry = "entry test";

        journal._entryLogFile = "JournalLog.csv";
        journal._prompts.Add("Prompt Test1");
        journal._prompts.Add("Prompt Test2");

        string prompt = journal.GeneratePrompt();

        journal.NewEntry(prompt);
        journal.Display();

    }
}