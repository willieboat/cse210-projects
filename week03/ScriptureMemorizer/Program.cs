using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Doctrine and Covenants", 64, 33);

        string ScriptureText = "Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work. And out of small things proceedeth that which is great.";

        Scripture scripture = new Scripture(reference, ScriptureText);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("You have completed the memorization. Proram will now exit.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
            scripture.HideRandomWords(3);

        }

    }
}
