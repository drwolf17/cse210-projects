class RoleBucket
{
    protected string _alignment;
    protected int _amountUnique;
    protected int _possibleRolesInBucket;

    public RoleBucket(string alignment)
    {
        _alignment = alignment;
        _amountUnique = 0;
        _possibleRolesInBucket = 0;
    }

    public virtual List<Role> CountPossible(List<Role> roles)
    {
        foreach (Role role in roles)
        {
            role.AddPossible();
            _possibleRolesInBucket++;

            if (role.IsUnique == true)
            {
                _amountUnique++;
            }
        }

        return roles;
    }

    public virtual List<Role> AddRoleSpawnChance(AllRoles allRoles)
    {
        _possibleRolesInBucket = _possibleRolesInBucket - 11 - allRoles.ConfirmedCoven -  2 - allRoles.ConfirmedTPow - allRoles.ConfirmedOtherUnique;

        double baseNonUniqueChance = ((double)_possibleRolesInBucket - 1)/(double)_possibleRolesInBucket;
        foreach (Role role in allRoles.Roles)
        {
            if (role.IsUnique == false || (role.IsUnique && role.TimesConfirmed == 0 && role.Alignment != "Power" && role.Faction != "Coven"))
            {
                role.AddProbability(baseNonUniqueChance);
            }

            else if (role.Faction == "Coven" && role.TimesConfirmed == 0 && allRoles.ConfirmedCoven < 4)
            {
                int n = 15 - allRoles.ConfirmedCoven;
                int k = 4 - allRoles.ConfirmedCoven;
                double chosenChance = Factorial(n - 1) / ((double)(Factorial(k - 1) * Factorial(n - 1 - (k - 1)))) /
                    (Factorial(n) / (Factorial(k) * Factorial(n - k)));
                role.AddProbability(baseNonUniqueChance);
                role.AddChosen(chosenChance);
            }

            else if (role.Faction == "Town" && role.Alignment == "Power" && role.TimesConfirmed == 0 && allRoles.ConfirmedTPow < 3)
            {
                int n = 5 - allRoles.ConfirmedTPow;
                int k = 3 - allRoles.ConfirmedTPow;
                double chosenChance = Factorial(n - 1) / ((double)(Factorial(k - 1) * Factorial(n - 1 - (k - 1)))) /
                    (Factorial(n) / (Factorial(k) * Factorial(n - k)));
                role.AddProbability(baseNonUniqueChance);
                role.AddChosen(chosenChance);
            }
        }

        return allRoles.Roles;
    }

    public double Factorial(int input)
    {
        double output = 1;
        if (input > 1)
        {
            for (int i = input; i > 1; i--)
            {
                output *= i;
            }
        }

        return output;
    }
}