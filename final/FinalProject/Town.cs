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
                    _possibleRolesInBucket++;
                }

                else if (_alignment == "Common" && role.Alignment != "Power")
                {
                    _possibleRolesInBucket++;
                }
            }
        }

        return roles;
    }

    public override List<Role> AddRoleSpawnChance(AllRoles allRoles)
    {
        if (_alignment == "Any")
        {
            _possibleRolesInBucket = _possibleRolesInBucket - 2 - allRoles.ConfirmedTPow;
        }

        else if (_alignment == "Power")
        {
            _possibleRolesInBucket -= allRoles.ConfirmedTPow;
        }

        double baseNonUniqueChance = ((double)_possibleRolesInBucket - 1)/(double)_possibleRolesInBucket;
        foreach (Role role in allRoles.Roles)
        {
            if (role.Faction == "Town" && (role.Alignment == _alignment || _alignment == "Common" || _alignment == "Any"))
            {
                if (role.Alignment != "Power")
                {
                    role.AddProbability(baseNonUniqueChance);
                }

                else if (role.Alignment == "Power" && role.TimesConfirmed == 0 && allRoles.ConfirmedTPow < 3 && _alignment != "Common")
                {
                    int n = 5 - allRoles.ConfirmedTPow;
                    int k = 3 - allRoles.ConfirmedTPow;
                    double chosenChance = Factorial(n - 1) / ((double)(Factorial(k - 1) * Factorial(n - 1 - (k - 1)))) /
                        (Factorial(n) / (Factorial(k) * Factorial(n - k)));
                    role.AddProbability(baseNonUniqueChance);
                    role.AddChosen(chosenChance);
                }
            }
        }

        return allRoles.Roles;
    }
}