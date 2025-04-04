class ConfirmedRole : RoleBucket
{
    private string _roleName;

    public ConfirmedRole(List<Role> roles, string alignment, string faction, string roleName) : base(roles, faction, alignment)
    {
        _roleName = roleName;
    }
}