class RoleBucket
{
    protected List<Role> _roles;
    protected string _alignment;
    protected string _faction;
    protected int _amountUnique;

    public RoleBucket(List<Role> roles, string alignment, string faction)
    {
        _roles = roles;
        _alignment = alignment;
        _faction = faction;
        _amountUnique = 0;
    }

    public virtual void AmountUnique()
    {
        foreach (Role role in _roles)
        {
            if (role.faction == _faction & role.alignment == _alignment & role.isUnique == true)
            {
                _amountUnique++;
            }
        }
    }
}