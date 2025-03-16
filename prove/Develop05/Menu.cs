public class Menu
{
    private bool _isRunning;
    private int _score;
    private List<Goals> _goals = new List<Goals>();

    public Menu()
    {
        _isRunning = true;
        _score = 0;
    }

    public void GiveOptions()
    {
        
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