class ConfirmedRole : RoleBucket
{
    private string _roleName;
    private Role _role;

    public ConfirmedRole(List<Role> roles, string alignment, string roleName) : base(roles, alignment)
    {
        _roleName = roleName;
        _role = roles.Find(x => x.RoleName == _roleName);
    }

    public override void CountPossible()
    {
        if (_role.IsUnique)
        {
            _amountUnique++;
            _roles.Find(x => x.RoleName == _roleName).AddPossible();
        }
    }
}