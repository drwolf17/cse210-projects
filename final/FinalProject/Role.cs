class Role
{
    private string _faction;
    private string _alignment;
    private string _roleName;
    private bool _isUnique;
    private int _timesConfirmed;
    private int _timesPossible;
    private double _spawnProbability;
    private List<double> _probabilityList = new List<double>();
    private List<double> _chosenChance = new List<double>();
    private List<double> _overallProbabilities = new List<double>();

    public Role(string faction, string alignment, string roleName, bool isUnique)
    {
        _faction = faction;
        _alignment = alignment;
        _roleName = roleName;
        _isUnique = isUnique;
        _timesConfirmed = 0;
        _timesPossible = 0;
        _spawnProbability = 0;
    }

    public string Faction
    {
        get
        {
            return _faction;
        }
    }
    public string Alignment
    {
        get
        {
            return _alignment;
        }
    } 

    public string RoleName
    {
        get
        {
            return _roleName;
        }
    }

    public bool IsUnique
    {
        get
        {
            return _isUnique;
        }
    }
    public int TimesConfirmed
    {
        get
        {
            return _timesConfirmed;
        }
    }
    public void AddConfirmed()
    {
        _timesConfirmed++;
    }
    public void AddPossible()
    {
        _timesPossible++;
    }

    public void AddProbability(double probability)
    {
        _probabilityList.Add(probability);
    }

    public void AddChosen(double probability)
    {
        _chosenChance.Add(probability);
    }

    public void CalculateSpawn()
    {
        double x = 1;
        double chanceSum = 0;
        foreach (double probability in _probabilityList)
        {
            x *= probability;
        }

        _spawnProbability = 1 - x;

        if (_chosenChance.Count > 0)
        {
            int y = 0;
            foreach (double chance in _chosenChance)
            {
                chanceSum += chance;
                y++;
            }

            _spawnProbability *= chanceSum / y;
        }
    }

    public void DisplaySpawnChance()
    {
        Console.WriteLine($"{_roleName}: {Math.Round(100 * _spawnProbability, 2)}%");
    }
}