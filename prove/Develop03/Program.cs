using System;

class Program
{
    static void Main(string[] args)
    {
        // Sets the scripture and the reference
        Reference reference = new Reference("Jacob", 3, 2);
        Scripture scripture = new Scripture("O all ye that are pure in heart, lift up your heads and receive the pleasing word of God, and feast upon his love; for ye may, if your minds are firm, forever.");

        // will loop for as long as there is still 
        // words that aren't hidden and the user has not
        // typed "quit".
        while (true)
        {
            Console.Clear();
            reference.DisplayReference();
            scripture.DisplayScripture();
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            // Ends loop if quit is typed or all the words are hidden, placed 
            // it here instead of having it in the while loop so it will
            // show all the words hidden before it exits the loop and thus
            // the program.
            if (Console.ReadLine() == "quit" || scripture.AreAllHidden())
            {
                break;
            }

            else
            {
                scripture.RandomHide(3);
            }
        }


    }
}