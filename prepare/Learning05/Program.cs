using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 12);

        Console.WriteLine(square.GetArea());
    }
}