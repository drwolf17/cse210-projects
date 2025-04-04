class ConfirmedRole : RoleBucket
{
    private string _roleName;

    public ConfirmedRole(List<Role> roles, string alignment, string faction, int amountUnique, string roleName) : base(roles, faction, alignment, amountUnique)
    {
        _roleName = roleName;
    }
}