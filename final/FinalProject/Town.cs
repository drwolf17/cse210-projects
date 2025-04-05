class Town : RoleBucket
{
    public Town(string alignment) : base(alignment) {}

    public override List<Role> CountPossible(List<Role> roles)
    {
        foreach (Role role in roles)
        {
            if (role.Faction == "Town")
            {
                if (_alignment == "Any" || _alignment == role.Alignment)
                {
                    role.AddPossible();
                    
                    if (role.IsUnique == true)
                    {
                        _amountUnique++;
                    }
                }

                else if (_alignment == "Common" & role.Alignment != "Power")
                {
                    role.AddPossible();
                }
            }
        }

        return roles;
    }
}