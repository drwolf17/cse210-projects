using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade: ");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);

        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        if (grade >= 70)
        {
            Console.WriteLine("You passed!!!");
        }
        else
        {
            Console.WriteLine("You failed, but you can learn more and try again!");
        }
    }
}