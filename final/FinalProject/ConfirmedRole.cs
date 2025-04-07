class ConfirmedRole : RoleBucket
{

    public ConfirmedRole(string alignment, Role role) : base(alignment) {}

    public override List<Role> CountPossible(List<Role> roles)
    {
        return roles;
    }

    public override List<Role> AddRoleSpawnChance(AllRoles allRoles)
    {
        return allRoles.Roles;
    }
}