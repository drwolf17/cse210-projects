using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 12);
        Rectangle rectangle = new Rectangle("blue", 5, 10);

        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetArea());
    }
}