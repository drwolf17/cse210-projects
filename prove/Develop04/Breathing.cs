public class Breathing : Mindfulness
{
    public Breathing() : base("Breathing", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public void BreathInOut(int breathIn, int breathOut)
    {
        Console.WriteLine("Breath in...");
        for (int i = 0; i < breathIn; i++)
        {
            Console.Write(breathIn - i);
            Console.Write("\b \b");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Breath out...");
        for (int i = 0; i < breathOut; i++)
        {
            Console.Write(breathOut - i);
            Console.Write("\b \b");
            Thread.Sleep(1000);
        }
        
    }
}