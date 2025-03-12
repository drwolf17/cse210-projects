using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpleGoal = new SimpleGoal("Test title", "Test desc", 50, true);

        simpleGoal.DisplayGoal();
    }
}