public class Reflection : Mindfulness
{
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;

    public Reflection() : base("Reflection",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") 
    {
        _reflectionPrompts = 
        [
        "Think of a time when you helped someone.",
        "Think of a time when you overcame a challenge",
        "Think of a time when you made someone feel happy.",
        "Think of a time when you solved a hard problem.",
        "Think of a time when you did something truly selfless"
        ];

        _reflectionQuestions =
        [
            "Why was this experience meaningful to you?",
            "What was your favorite part of this experience?",
            "What can be learned from this experience?",
            "How did you feel when it was complete?",
            "Was this something you had done before?",
            "How much did this experience impact your life?",
            "How did you get started?"
        ];
    }

    public void ReflectionMethod()
    {
        GenericGreeting();
        DurationPrompt();

        Console.Clear();
        Console.WriteLine("Get ready...");
        WaitAnimtion(5);

        string prompt = RandomString(_reflectionPrompts);
        _loops = (int)Math.Ceiling((double) _duration / 10);

        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"  -- {prompt} --");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questinos relating to the experience.");
        Console.WriteLine("");
        Console.Write("You will begin in: ");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(RandomString(_reflectionQuestions));

    }
}