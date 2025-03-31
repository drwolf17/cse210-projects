public class Listing : Mindfulness
{
    private List<string> _listingPrompts;

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
    {
        _listingPrompts = 
        [
            "Who are some people that are very important to you?",
            "What are some positive qualities that you have?",
            "What are some things you can do to improve?",
            "What are some times you've felt the spirit this week?",
            "What are some positive experiences you've felt this week?"
        ];
    }

    public void ListingMethod()
    {
        GenericGreeting();
        DurationPrompt();

        GetReady();

        string prompt = RandomString(_listingPrompts);

        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"  -- {prompt} --");
        Console.WriteLine("");
        Console.Write("You will begin in: ");

        Countdown(5);
        Console.WriteLine("");

        int timesListed = ListingItems();

        Console.WriteLine("");
        Console.WriteLine($"You listed {timesListed} items!");
        Console.WriteLine("");

        GenericEnding();
    }

    public int ListingItems()
    {
        DateTime startTime = DateTime.Now;
        int timesListed = 0;

        while (DateTime.Now < startTime.AddSeconds(_duration))
        {
            Console.Write(">> ");
            Console.ReadLine();

            timesListed++;
        }

        return timesListed;
    }
}