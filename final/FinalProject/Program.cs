using System;

class Program
{
    static void Main(string[] args)
    {
        // List<string> buckets = 
        // [
        //     "Crusader",
        //     "Town Investigative",
        //     "Town Investigative",
        //     "Town Power",
        //     "Town Power",
        //     "Town Protective",
        //     "Random Town",
        //     "Random Town",
        //     "Common Town",
        //     "Common Town",
        //     "Coven Power",
        //     "Coven Killing",
        //     "Common Coven",
        //     "Random Coven",
        //     "Random Neutral"
        // ];

        List<string> allAny = 
        [
            "Random Town",
            "Common Town",
            "Common Town",
            "Town Support",
            "Town Power"
        ];

        RoleList roleList = new RoleList(allAny);

        roleList.CountForRolesAndBuckets();

        roleList.SpawnChance();

        Console.WriteLine("Stop");
    }
}