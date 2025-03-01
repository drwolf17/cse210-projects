public class Breathing : Mindfulness
{
    public Breathing() : base("Breathing", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public void BreathingMethod()
    {
        GenericGreeting();
        DurationPrompt();

        Console.Clear();
        Console.WriteLine("Get ready...");
        WaitAnimtion(5);

        int loops = (int)Math.Ceiling((double) _duration / 10);

        for (int i = 0; i < loops; i++)
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
        for (int i = 0; i < breathIn; i++)
        {
            Console.Write(breathIn - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
        Console.Write("Breath out...");
        for (int i = 0; i < breathOut; i++)
        {
            Console.Write(breathOut - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}