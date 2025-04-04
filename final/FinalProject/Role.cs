class Role
{
    private string _faction;
    private string _alignment;
    private bool _isUnique;
    private List<double> _probabilityList;
    private List<double> _overallProbabilities;

    public Role(string faction, string alignment, bool isUnique)
    {
        _faction = faction;
        _alignment = alignment;
        _isUnique = isUnique;
    }

    public void AddProbability(double probability)
    {
        _probabilityList.Add(probability);
    }
}