using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        menu.Load("goalsSaveTest.txt");
        menu.DisplayGoals();
    }
}