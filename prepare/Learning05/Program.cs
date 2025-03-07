using System;

class Program
{
    static void Main(string[] args)
    {
        // Square square = new Square("red", 12);
        // Rectangle rectangle = new Rectangle("blue", 5, 10);
        // Circle circle = new Circle("green", 6);

        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 12));
        shapes.Add(new Rectangle("blue", 5, 10));
        shapes.Add(new Circle("green", 6));

        foreach (Shape shape in shapes)
        {
            Console.Write(shape.GetColor() + " ");
            Console.WriteLine(shape.GetArea());
        }
    }
}