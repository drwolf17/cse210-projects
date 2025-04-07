class Menu 
{
    private RoleList _roleList;
    private string _fileName;

    public Menu() {}

    public void MenuMethod()
    {
        Console.WriteLine("Input file name of role list you want to calculate the odds of a role appearing of");
        Console.Write(">>");
        _fileName = Console.ReadLine();

        _roleList = new RoleList(Load());

        _roleList.CountForRolesAndBuckets();

        _roleList.SpawnChance();
    }

    public List<string> Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        List<string> buckets = [.. lines];

        return buckets;
    }
}