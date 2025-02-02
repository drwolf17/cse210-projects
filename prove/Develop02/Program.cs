class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();


        journal._prompts.Add("What was your favorite moment of the day?");
        journal._prompts.Add("What was the hardest part of the day?");
        journal._prompts.Add("What did you spend your time doing?");
        journal._prompts.Add("Did you learn anything new?");
        journal._prompts.Add("Did anything exciting happen?");
        journal._prompts.Add("Who's lives did you bless?");

        string userSelection = "";

        while (userSelection != "5")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display your current list of entries");
            Console.WriteLine("3. Load a list of entries from a file");
            Console.WriteLine("4. Save your current list of entries");
            Console.WriteLine("5. Exit the program");
            Console.Write(">>");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                journal.NewEntry();
            }
            else if (userSelection == "2")
            {
                if (journal._entries.Count == 0)
                {
                    Console.WriteLine("There are no entries yet");
                    Console.WriteLine("");
                }
                else
                {
                    journal.Display();
                }
            }
        }


    }
}