class Coven : RoleBucket
{
    public Coven(string alignment) : base(alignment) {}

    public override List<Role> CountPossible(List<Role> roles)
    {
        foreach (Role role in roles)
        {
            if (role.Faction == "Coven")
            {
                if (_alignment == "Any" || _alignment == role.Alignment)
                {
                    _possibleRolesInBucket++;
                }

                else if (_alignment == "Common" && role.Alignment != "Power" && role.Alignment != "Killing")
                {
                    _possibleRolesInBucket++;
                }
            }
        }

        return roles;
    }

    public override List<Role> AddRoleSpawnChance(AllRoles allRoles)
    {
        int confRoleInBucket = 0;
        if (_alignment == "Any")
        {
            confRoleInBucket = allRoles.ConfirmedCoven;
        }

        foreach (Role role in allRoles.Roles)
        {
            if (role.Faction == "Coven")
                if (_alignment == "Common" && role.Alignment != "Power" && role.Alignment != "Killing" && role.TimesConfirmed > 0)
                {
                    confRoleInBucket++;
                }

                else if (_alignment == role.Alignment && role.TimesConfirmed > 0)
                {
                    confRoleInBucket++;
                }
        }

        int effectiveRolesInBucket = _possibleRolesInBucket - confRoleInBucket;

        double baseNonUniqueChance = ((double)effectiveRolesInBucket - 1)/(double)effectiveRolesInBucket;
        foreach (Role role in allRoles.Roles)
        {
            if (role.Faction == "Coven" && role.TimesConfirmed == 0)
            {
                if (role.Alignment == _alignment || _alignment == "Any" || (_alignment == "Common" && role.Alignment != "Power" && role.Alignment != "Killing"))
                {
                    int n = _possibleRolesInBucket - confRoleInBucket;
                    int k = effectiveRolesInBucket;
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