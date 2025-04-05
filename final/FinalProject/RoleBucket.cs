class RoleBucket
{
    protected List<Role> _roles;
    protected string _alignment;
    protected int _amountUnique;
    protected int _possibleRolesAmount;

    public RoleBucket(List<Role> roles, string alignment)
    {
        _roles = roles;
        _alignment = alignment;
        _amountUnique = 0;
        _possibleRolesAmount = 0;
    }

    public List<Role> Roles { get; }

    public virtual void CountPossible()
    {
        foreach (Role role in _roles)
        {
            if (role.IsUnique == true)
            {
                _amountUnique++;
                role.AddPossible();
            }
        }
    }
}