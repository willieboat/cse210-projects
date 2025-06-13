using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simple = new Assignment("William Boateng", "Division");
        Console.WriteLine(simple.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Samson Ahi", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Matilda Wesley", "PanAfricanism", "Neo Colonialism");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
