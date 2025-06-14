using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Start();
            else if (choice == "2")
                new ReflectionActivity().Start();
            else if (choice == "3")
                new ListingActivity().Start();
            else if (choice == "4")
                break;
            else
            {
                Console.WriteLine("Invalid input.");
                Thread.Sleep(1000);
            }
        }
    }
}
