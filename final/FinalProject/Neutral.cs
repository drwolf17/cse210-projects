class Neutral : RoleBucket
{
    public Neutral(List<Role> roles, string alignment) : base(roles, alignment) {}

    public override void CountPossible()
    {
        foreach (Role role in _roles)
        {
            if (role.Faction == "Neutral")
            {
                if (_alignment == "Any" || _alignment == role.Alignment)
                {
                    role.AddPossible();
                    
                    if (role.IsUnique == true)
                    {
                        _amountUnique++;
                    }
                }
            }
        }
    }
}