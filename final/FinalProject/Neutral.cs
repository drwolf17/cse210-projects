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
                    _possibleRolesInBucket++;
                    
                    if (role.IsUnique == true)
                    {
                        _amountUnique++;
                    }
                }
            }
        }

        return roles;
    }
    public override List<Role> AddRoleSpawnChance(AllRoles allRoles)
    {
        foreach (Role role in allRoles.Roles)
        {
            if (role.Faction == "Neutral" && (role.Alignment == _alignment || role.Alignment == "Any") && role.IsUnique && role.TimesConfirmed > 0)
            {
                _possibleRolesInBucket--;
            }
        }

        double baseNonUniqueChance = ((double)_possibleRolesInBucket - 1)/(double)_possibleRolesInBucket;
        foreach (Role role in allRoles.Roles)
        {
            if (role.Faction == "Neutral" && (role.Alignment == _alignment || _alignment == "Any") && (role.IsUnique == false || (role.IsUnique && role.TimesConfirmed == 0)))
            {
                role.AddProbability(baseNonUniqueChance);
            }
        }

        return allRoles.Roles;
    }
}