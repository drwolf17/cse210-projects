using System;

class Program
{
    static void Main(string[] args)
    {
        Mindfulness mindfulness = new Mindfulness("Breathing", "Ex. description");

        mindfulness.GenericGreeting();
        mindfulness.DurationPrompt();
    }
}


