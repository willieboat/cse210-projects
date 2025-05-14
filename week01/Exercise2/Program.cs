using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage?: ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        string letter = "";

        if (percent >= 90)

        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("CONGRATULATIONS YOU PASSED!!!");
        }
        else
        {
            Console.WriteLine("YOU FAILED BUT YOU CAN DO BETTER NEXT TIME");
        }

    }
}