using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = 1;
        int total = 0;
        int largest = 0;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
            numbers.Add(userNumber);
            }
        }

        foreach (int number in numbers)
        {
            total += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        float average = (float)total / numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");

    }
}