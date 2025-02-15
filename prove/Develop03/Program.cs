using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureWord testWord = new ScriptureWord("test");
        Reference testReference1 = new Reference("Enos");
        Reference testReference2 = new Reference("Moroni", 3);
        Reference testReference3 = new Reference("1 Nephi", 10, 4);
        Reference testReference4 = new Reference("Jacob", 3, 2, 5);

        testReference1.DisplayReference();
        testReference2.DisplayReference();
        testReference3.DisplayReference();
        testReference4.DisplayReference();


    }
}