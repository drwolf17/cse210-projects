using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        menu.Load("goalsTest.txt");
        menu.DisplayGoals();
        menu.Save("goalsSaveTest.txt");
    }
}