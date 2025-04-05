class RoleBucket
{
    protected string _alignment;
    protected int _amountUnique;
    protected int _rolesInBucket;

    public RoleBucket(string alignment)
    {
        _alignment = alignment;
        _amountUnique = 0;
        _rolesInBucket = 0;
    }

    public virtual List<Role> CountPossible(List<Role> roles)
    {
        foreach (Role role in roles)
        {
            if (role.IsUnique == true)
            {
                _amountUnique++;
                role.AddPossible();
            }
        }

        return roles;
    }
}