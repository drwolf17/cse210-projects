class ConfirmedRole : RoleBucket
{
    private Role _role;

    public ConfirmedRole(string alignment, Role role) : base(alignment)
    {
        _role = role;
    }

    public override List<Role> CountPossible(List<Role> roles)
    {
        if (_role.IsUnique)
        {
            _amountUnique++;
            roles.Find(x => x.RoleName == _role.RoleName).AddPossible();
        }

        return roles;
    }

    public override List<Role> AddRoleSpawnChance(AllRoles allRoles)
    {
        return allRoles.Roles;
    }
}