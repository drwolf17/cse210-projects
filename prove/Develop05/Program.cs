using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpleGoal = new SimpleGoal("Simple test title", "Simple test desc", 50, true);
        EternalGoal eternalGoal = new EternalGoal("Eternal test title", "Eternal test desc", 100, 1);

        simpleGoal.DisplayGoal();
        Console.WriteLine("");
        eternalGoal.DisplayGoal();
    }
}