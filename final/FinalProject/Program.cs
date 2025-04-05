using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> buckets = 
        [
            "Crusader",
            "Town Investigative",
            "Town Investigative",
            "Town Power",
            "Town Power",
            "Town Protective",
            "Random Town",
            "Random Town",
            "Common Town",
            "Common Town",
            "Coven Power",
            "Coven Killing",
            "Common Coven",
            "Random Coven",
            "Random Neutral"
        ];

        RoleList roleList = new RoleList(buckets);

        roleList.CountForRolesAndBuckets();

        Console.WriteLine("Stop");
    }
}