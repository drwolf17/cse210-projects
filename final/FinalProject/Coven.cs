class Coven : RoleBucket
{
    public Coven(List<Role> roles, string alignment) : base(roles, alignment) {}

    public override void CountPossible()
    {
        foreach (Role role in _roles)
        {
            if (role.Faction == "Coven")
            {
                if (_alignment == "Any" || _alignment == role.Alignment)
                {
                    _amountUnique++;
                    role.AddPossible();
                }

                else if (_alignment == "Common" & role.Alignment != "Power" & role.Alignment != "Killing")
                {
                    _amountUnique++;
                    role.AddPossible();
                }
            }
        }
    }
}