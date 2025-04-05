class Role
{
    private string _faction;
    private string _alignment;
    private string _roleName;
    private bool _isUnique;
    private int _timesConfirmed;
    private List<double> _probabilityList;
    private List<double> _overallProbabilities;

    public Role(string faction, string alignment, string roleName, bool isUnique)
    {
        _faction = faction;
        _alignment = alignment;
        _roleName = roleName;
        _isUnique = isUnique;
        _timesConfirmed = 0;
    }

    public string Faction { get; }
    public string Alignment { get; }

    public string RoleName { get; }

    public bool IsUnique { get; }
    public int TimesConfirmed { get; }
    public void AddConfirmed()
    {
        _timesConfirmed++;
    }

    public void AddProbability(double probability)
    {
        _probabilityList.Add(probability);
    }
}