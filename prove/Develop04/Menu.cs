public class Menu
{
    private int _userChoice;
    private bool _isRunning;

    public Menu()
    {
        _userChoice = 0;
        _isRunning = true;
    }

    public bool MenuMethod()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start Breathing Activity");
        Console.WriteLine("   2. Start Reflection Activity");
        Console.WriteLine("   3. Start Listing Activity");
        Console.WriteLine("   4. Quit");
        Console.Write(">> ");
        
        _userChoice = int.Parse(Console.ReadLine());

        RunSelected();

        return _isRunning;
    }

    public void RunSelected()
    {
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();

        Console.Clear();
        
        if (_userChoice == 1)
        {
            breathing.BreathingMethod();
        }

        else if (_userChoice == 2)
        {
            reflection.ReflectionMethod();
        }

        else if (_userChoice == 3)
        {
            listing.ListingMethod();
        }

        else if (_userChoice == 4)
        {
            Console.WriteLine("Thank you for using the Mindfulness program.");
            _isRunning = false;
        }

        else 
        {
            Console.WriteLine("That is not a valid option.");
        }
    }
}