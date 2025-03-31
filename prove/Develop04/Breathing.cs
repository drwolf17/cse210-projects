public class Breathing : Mindfulness
{
    public Breathing() : base("Breathing", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public void BreathingMethod()
    {
        GenericGreeting();
        DurationPrompt();

        GetReady();

        _loops = (int)Math.Ceiling((double) _duration / 10);

        for (int i = 0; i < _loops; i++)
        {
            BreathInOut(5, 5);
            Console.WriteLine("");
        }

        Console.WriteLine("");
        GenericEnding();
    }
    public void BreathInOut(int breathIn, int breathOut)
    {
        Console.WriteLine("");
        Console.Write("Breath in...");
        
        Countdown(breathIn);

        Console.WriteLine("");
        Console.Write("Breath out...");
        
        Countdown(breathOut);
        
    }
}