class RoleBucket
{
    protected List<Role> _roles;
    protected string _alignment;
    protected string _faction;
    protected int _amountUnique;

    public RoleBucket(List<Role> roles, string alignment, string faction, int amountUnique)
    {
        _roles = roles;
        _alignment = alignment;
        _faction = faction;
        _amountUnique = amountUnique;
    }
}