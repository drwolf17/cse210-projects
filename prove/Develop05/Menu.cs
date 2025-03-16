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
        Console.WriteLine("Choose a Menu Option:");
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

    public void CreateGoal()
    {
        Console.WriteLine("Choose a Goal Type:");
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write(">>");
        
        int goalChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?");
        Console.Write(">>");
        string goalTitle = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal?");
        Console.Write(">>");
        string goalDesc = Console.ReadLine();

        Console.WriteLine("How many points would you like it to be worth?");
        Console.Write(">>");
        int goalScore = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalTitle, goalDesc, goalScore, false);
            _goals.Add(simpleGoal);
        }

        else if (goalChoice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(goalTitle, goalDesc, goalScore, 0);
            _goals.Add(eternalGoal);
        }

        else if (goalChoice == 3)
        {
            Console.WriteLine("How many times would you need to accomplish it to achieve the goal?");
            Console.Write(">>");
            int goalEnd = int.Parse(Console.ReadLine());

            Console.WriteLine("How many bonus points would you like when achieve the goal?");
            Console.Write(">>");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalTitle, goalDesc, goalScore, goalBonus, 0, goalEnd);
            _goals.Add(checklistGoal);
        }
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
        int count = 1;
        foreach (Goals goal in _goals)
        {
            Console.Write(count + ". ");
            goal.DisplayGoal();
            count++;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Choose a Goal to Record:");
        Console.WriteLine("----------------------");

        DisplayGoals();

        Console.Write(">>");
        int goalChoice = int.Parse(Console.ReadLine()) - 1;

        _score += _goals[goalChoice].RecordEvent();
    }
}