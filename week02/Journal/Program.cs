using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What challenge did I face today and how did I handle it?"
        };

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("> ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Write new entry
                    Entry entry = new Entry();

                    Random random = new Random();
                    int index = random.Next(prompts.Count);
                    string prompt = prompts[index];

                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    entry._promptText = prompt;
                    entry._entryText = response;
                    entry._date = DateTime.Now.ToString("MM/dd/yyyy");

                    journal.AddEntry(entry);
                    break;

                case "2": // Display journal
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayAll();
                    break;

                case "3": // Save to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4": // Load from file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "5": // Exit
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye and see you again soon!");
    }
}
