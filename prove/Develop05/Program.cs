using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        bool isRunning = true;
        int userSelection;

        while (isRunning)
        {
            userSelection = menu.GiveOptions();

            if (userSelection == 1)
            {
                menu.CreateGoal();
            }

            else if (userSelection == 2)
            {
                menu.DisplayGoals();
            }

            else if (userSelection == 3)
            {
                menu.Save();
            }

            else if (userSelection == 4)
            {
                menu.Load();
            }

            else if (userSelection == 5)
            {
                menu.RecordEvent();
            }

            else if (userSelection == 6)
            {
                isRunning = false;
            }

        }
    }
}