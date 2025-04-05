class AllRoles
{
    private List<Role> _allRoles;
    private int _possibleCoven;
    private int _confirmedCoven;
    private int _possibleTPow;
    private int _confirmedTPow;

    public AllRoles()
    {
        _possibleCoven = 0;
        _confirmedCoven = 0;
        _possibleTPow = 0;
        _confirmedTPow = 0;

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

    public List<Role> GetAllRoles
    {
        get
        {
            return _allRoles;
        }
        set
        {
            _allRoles = value;
        }
    }
    public int PossibleCoven
    {
        get
        {
            return _possibleCoven;
        }
    }
    public int ConfirmedCoven
    {
        get
        {
            return _confirmedCoven;
        }
    }
    public int PossibleTPow
    {
        get
        {
            return _possibleTPow;
        }
    }
    public int ConfirmedTPow
    {
        get
        {
            return _confirmedTPow;
        }
    }

    public RoleBucket CreateBucket(string listBucket)
    {
        if (listBucket == "Any")
        {
            RoleBucket roleBucket = new RoleBucket("Any");
            _possibleTPow++;
            _possibleCoven++;
            return roleBucket;
        }

        else if (listBucket == "Random Town")
        {
            Town roleBucket = new Town("Any");
            _possibleTPow++;
            return roleBucket;
        }

        else if (listBucket == "Common Town")
        {
            Town roleBucket = new Town("Common");
            return roleBucket;
        }

        else if (listBucket == "Town Investigative")
        {
            Town roleBucket = new Town("Investigative");
            return roleBucket;
        }

        else if (listBucket == "Town Protective")
        {
            Town roleBucket = new Town("Protective");
            return roleBucket;
        }

        else if (listBucket == "Town Killing")
        {
            Town roleBucket = new Town("Killing");
            return roleBucket;
        }

        else if (listBucket == "Town Support")
        {
            Town roleBucket = new Town("Support");
            return roleBucket;
        }

        else if (listBucket == "Town Power")
        {
            Town roleBucket = new Town("Power");
            _confirmedTPow++;
            return roleBucket;
        }

        else if (listBucket == "Random Coven")
        {
            Coven roleBucket = new Coven("Any");
            _confirmedCoven++;
            return roleBucket;
        }

        else if (listBucket == "Common Coven")
        {
            Coven roleBucket = new Coven("Common");
            _confirmedCoven++;
            return roleBucket;
        }

        else if (listBucket == "Coven Power")
        {
            Coven roleBucket = new Coven("Power");
            _confirmedCoven++;
            return roleBucket;
        }

        else if (listBucket == "Coven Killing")
        {
            Coven roleBucket = new Coven("Killing");
            _confirmedCoven++;
            return roleBucket;
        }

        else if (listBucket == "Coven Deception")
        {
            Coven roleBucket = new Coven("Deception");
            _confirmedCoven++;
            return roleBucket;
        }

        else if (listBucket == "Coven Utility")
        {
            Coven roleBucket = new Coven("Utiliy");
            _confirmedCoven++;
            return roleBucket;
        }

        else if (listBucket == "Random Neutral")
        {
            Neutral roleBucket = new Neutral("Any");
            return roleBucket;
        }


        else if (listBucket == "Neutral Evil")
        {
            Neutral roleBucket = new Neutral("Evil");
            return roleBucket;
        }

        else if (listBucket == "Neutral Killing")
        {
            Neutral roleBucket = new Neutral("Killing");
            return roleBucket;
        }

        else if (listBucket == "Neutral Apocalypse")
        {
            Neutral roleBucket = new Neutral("Apocalypse");
            return roleBucket;
        }

        else
        {
            Role confRole = _allRoles.Find(x => x.RoleName == listBucket);

            if (confRole == null)
            {
                throw new Exception();
            }

            else
            {
                ConfirmedRole roleBucket = new ConfirmedRole(confRole.Alignment, confRole);

                if (confRole.Faction == "Town" & confRole.Alignment == "Power")
                {
                    _confirmedTPow++;
                }

                else if (confRole.Faction == "Coven")
                {
                    _confirmedCoven++;
                }

                _allRoles.Find(x => x.RoleName == listBucket).AddConfirmed();
                
                return roleBucket;
            }
        }
    }
}