class RoleList
{
    private AllRoles _allRoles;
    private List<RoleBucket> _roleBuckets = new List<RoleBucket>();

    public RoleList(List<string> buckets)
    {
        _allRoles = new AllRoles();

        foreach (string bucket in buckets)
        {
            try
            {
                _roleBuckets.Add(_allRoles.CreateBucket(bucket));
            }
            catch (Exception)
            {
                Console.WriteLine($"{bucket} is not a possible Role Bucket.");
                Console.WriteLine("");
                Console.WriteLine("Remember to input the role/bucket as exactly seen");
                Console.WriteLine("in game including spaces and capitalization.");
            }
        }
    }

    public void CountForRolesAndBuckets()
    {
        foreach (RoleBucket roleBucket in _roleBuckets)
        {
            _allRoles.Roles = roleBucket.CountPossible(_allRoles.Roles);
        }
    }
}