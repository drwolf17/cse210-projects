using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpleGoal = new SimpleGoal("Simple test title", "Simple test desc", 50, true);
        EternalGoal eternalGoal = new EternalGoal("Eternal test title", "Eternal test desc", 100, 1);
        ChecklistGoal checklistGoal1 = new ChecklistGoal("Checklist test title", "Checklist test desc", 50, 100, 2, 4);
        ChecklistGoal checklistGoal2 = new ChecklistGoal("Checklist test title", "Checklist test desc", 50, 100, 4, 4);

        simpleGoal.DisplayGoal();
        Console.WriteLine("");
        eternalGoal.DisplayGoal();
        Console.WriteLine("");
        checklistGoal1.DisplayGoal();
        Console.WriteLine("");
        checklistGoal2.DisplayGoal();
    }
}