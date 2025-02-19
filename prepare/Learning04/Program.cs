using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Daniel Wolf", "Geometry", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(" ");

        WritingAssignemnt writingAssignemnt = new WritingAssignemnt("Daniel Wolf", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignemnt.GetSummary());
        Console.WriteLine(writingAssignemnt.GetWritingInfo());
    }
}