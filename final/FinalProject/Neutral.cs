class Neutral : RoleBucket
{
    public Neutral(string alignment) : base(alignment) {}

    public override List<Role> CountPossible(List<Role> roles)
    {
        foreach (Role role in roles)
        {
            if (role.Faction == "Neutral")
            {
                if (_alignment == "Any" || _alignment == role.Alignment)
                {
                    role.AddPossible();
                    
                    if (role.IsUnique == true)
                    {
                        _amountUnique++;
                    }
                }
            }
        }

        return roles;
    }
}