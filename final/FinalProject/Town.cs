class Town : RoleBucket
{
    public Town(List<Role> roles, string alignment) : base(roles, alignment) {}

    public override void CountPossible()
    {
        foreach (Role role in _roles)
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
    }
}