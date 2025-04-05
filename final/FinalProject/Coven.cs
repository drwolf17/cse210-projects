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
                    _amountUnique++;
                    role.AddPossible();
                }

                else if (_alignment == "Common" && role.Alignment != "Power" && role.Alignment != "Killing")
                {
                    _amountUnique++;
                    role.AddPossible();
                }
            }
        }

        return roles;
    }
}