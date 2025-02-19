using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Daniel Wolf", "Geometry");
        Console.WriteLine(assignment.GetSummary());
    }
}