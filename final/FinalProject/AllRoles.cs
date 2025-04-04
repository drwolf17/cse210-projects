class AllRoles
{
    private List<Role> _allRoles;

    public AllRoles()
    {
        _allRoles = 
        [
            new Role("Town", "Investigative", "Coroner", false),
            new Role("Town", "Investigative", "Investigator", false),
            new Role("Town", "Investigative", "Lookout", false),
            new Role("Town", "Investigative", "Psychic", false),
            new Role("Town", "Investigative", "Seer", false),
            new Role("Town", "Investigative", "Sheriff", false),
            new Role("Town", "Investigative", "Spy", false),
            new Role("Town", "Investigative", "Tracker", false),

            new Role("Town", "Protective", "Bodyguard", false),
            new Role("Town", "Protective", "Cleric", false),
            new Role("Town", "Protective", "Crusader", false),
            new Role("Town", "Protective", "Oracle", false),
            new Role("Town", "Protective", "Trapper", false),

            new Role("Town", "Killing", "Deputy", false),
            new Role("Town", "Killing", "Trickster", false),
            new Role("Town", "Killing", "Veteran", false),
            new Role("Town", "Killing", "Vigilante", false),

            new Role("Town", "Support", "Admirer", false),
            new Role("Town", "Support", "Amnesiac", false),
            new Role("Town", "Support", "Retributionist", false),
            new Role("Town", "Support", "Socialite", false),
            new Role("Town", "Support", "Tavern Keeper", false),

            new Role("Town", "Power", "Jailor", true),
            new Role("Town", "Power", "Marshal", true),
            new Role("Town", "Power", "Mayor", true),
            new Role("Town", "Power", "Monarch", true),
            new Role("Town", "Power", "Prosecutor", true),


            new Role("Coven", "Power", "Coven Leader", true),
            new Role("Coven", "Power", "Hex Master", true),
            new Role("Coven", "Power", "Witch", true),

            new Role("Coven", "Killing", "Conjurer", true),
            new Role("Coven", "Killing", "Jinx", true),
            new Role("Coven", "Killing", "Ritualist", true),

            new Role("Coven", "Deception", "Dreamweaver", true),
            new Role("Coven", "Deception", "Enchanter", true),
            new Role("Coven", "Deception", "Illusionist", true),
            new Role("Coven", "Deception", "Medusa", true),

            new Role("Coven", "Utility", "Necromancer", true),
            new Role("Coven", "Utility", "Poisoner", true),
            new Role("Coven", "Utility", "Potion Master", true),
            new Role("Coven", "Utility", "Voodoo Master", true),
            new Role("Coven", "Utility", "Wildling", true),


            new Role("Neutral", "Evil", "Doomsayer", false),
            new Role("Neutral", "Evil", "Executioner", true),
            new Role("Neutral", "Evil", "Jester", false),
            new Role("Neutral", "Evil", "Pirate", true),

            new Role("Neutral", "Killing", "Arsonist", false),
            new Role("Neutral", "Killing", "Serial Killer", false),
            new Role("Neutral", "Killing", "Shroud", false),
            new Role("Neutral", "Killing", "Werewolf", false),

            new Role("Neutral", "Apocalypse", "Baker", true),
            new Role("Neutral", "Apocalypse", "Berserker", true),
            new Role("Neutral", "Apocalypse", "Plaguebearer", true),
            new Role("Neutral", "Apocalypse", "Soul Collector", true)
        ];
    }

    public List<Role> GetAllRoles()
    {
        return _allRoles;
    }
}