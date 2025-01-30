using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        DateTime currentTime = DateTime.Now;

        entry._prompt = "prompt test";
        entry._date = currentTime.ToShortDateString() + " test";
        entry._entry = "entry test";
        entry.Display();
    }
}