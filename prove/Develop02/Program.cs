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
            else if (userSelection == "3")
            {
                Console.WriteLine("Please select a file");
                Console.Write(">>");
                string loadFile = Console.ReadLine();

                if (System.IO.Path.Exists(loadFile))
                {
                    journal.Load(loadFile);
                    Console.WriteLine($"{loadFile} successfully loaded");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"The file {loadFile} does not exist.");
                    Console.WriteLine("");
                }
            }
            else if (userSelection == "4")
            {
                Console.WriteLine("Please select a file");
                Console.Write(">>");
                string saveFile = Console.ReadLine();

                if (System.IO.Path.Exists(saveFile))
                {
                    Console.WriteLine($"Saving will overwrite the contents of {saveFile}. Type 1 if you are sure");
                    Console.Write(">>");
                    string overwriteSave = Console.ReadLine();

                    if (overwriteSave == "1")
                    {
                    journal.Save(saveFile);
                    Console.WriteLine($"Entries have been successfully saved to {saveFile}");
                    Console.WriteLine("");
                    }
                }
                else
                {
                    journal.Save(saveFile);
                    Console.WriteLine($"Entries have been successfully saved to {saveFile}");
                    Console.WriteLine("");
                }               
            }
            else if (userSelection == "5")
            {
                Console.WriteLine("Unsave entries will be lost. Type 1 if you still wish to exit the program");
                Console.Write(">>");
                string exitDecision = Console.ReadLine();

                if (exitDecision == "1")
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    userSelection = "";
                }
            }
        }


    }
}