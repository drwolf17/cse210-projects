class Role
{
    private string _faction;
    private string _alignment;
    private string _roleName;
    private bool _isUnique;
    private List<double> _probabilityList;
    private List<double> _overallProbabilities;

    public Role(string faction, string alignment, string roleName, bool isUnique)
    {
        _faction = faction;
        _alignment = alignment;
        _roleName = roleName;
        _isUnique = isUnique;
    }

    public string faction { get; }
    public string alignment { get; }

    public string roleName { get; }

    public bool isUnique { get; }

    public void AddProbability(double probability)
    {
        _probabilityList.Add(probability);
    }
}