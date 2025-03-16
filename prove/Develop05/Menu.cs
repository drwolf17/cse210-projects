public class Menu
{

    private int _score;
    private List<Goals> _goals = new List<Goals>();

    public Menu()
    {
        _score = 0;
    }

    public int GiveOptions()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("");
        Console.WriteLine("    Menu Options:");
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write(">>");

        int userSelection = int.Parse(Console.ReadLine()); 
        
        return userSelection;
    }

    public int GetScore()
    {
        return _score;
    }

    public void Load(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        _goals.Clear();

        foreach (string line in lines)
        {

            string[] parts = line.Split('~');

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(simpleGoal);
            }

            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                _goals.Add(eternalGoal);
            }

            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }

            else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }

    public void Save(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);

            foreach (Goals goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (Goals goal in _goals)
        {
            goal.DisplayGoal();
        }
    }
}