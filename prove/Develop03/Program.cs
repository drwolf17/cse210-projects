using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureWord testWord1 = new ScriptureWord();
        ScriptureWord testWord2 = new ScriptureWord("test");

        Console.WriteLine("v Should be blank v");
        Console.WriteLine(testWord1.GetWord());
        Console.WriteLine("^ Should be blank ^");
        Console.WriteLine(testWord2.GetWord());
    }
}