using System;

class Program
{
    static void Main(string[] args)
    {
        Reference testReference = new Reference("Jacob", 3, 2);
        Scripture testScripture = new Scripture("O all ye that are pure in heart, lift up your heads and receive the pleasing word of God, and feast upon his love; for ye may, if your minds are firm, forever.");


        testReference.DisplayReference();
        testScripture.DisplayScripture();

        testScripture.RandomHide(3);
        testScripture.DisplayScripture();


    }
}