class RoleBucket
{
    protected List<Role> _roles;
    protected string _alignment;
    protected int _amountUnique;

    public RoleBucket(List<Role> roles, string alignment)
    {
        _roles = roles;
        _alignment = alignment;
        _amountUnique = 0;
    }

    public virtual void AmountUnique()
    {
        foreach (Role role in _roles)
        {
            if (role.isUnique == true)
            {
                _amountUnique++;
            }
        }
    }
}